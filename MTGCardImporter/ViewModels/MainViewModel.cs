using Microsoft.Win32;
using MTGCardImporter.Base;
using MTGCardImporter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MTGCardImporter.ViewModels
{
    class MainViewModel : Notify
    {

        public List<string> foilTypes { get => new List<string>() { "Normal", "Foil" }; }

        public MainViewModel() : base()
        {
            loadCardDatabase = new RelayCommand(LoadCardDatabaseFromMTGJson, param => canExecuteLoadCardDatabase);
            loadCSV = new RelayCommand(LoadCSVFromFile, param => canExecuteLoadCSV);
            saveCSV = new RelayCommand(SaveCSVToFile, param => canExecuteSaveCSV);

            _myCards.CollectionChanged += _myCards_CollectionChanged;
        }

        private void _myCards_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems == null)
                return;

            for(int i = 0; i < e.NewItems.Count; i++)
            {
                var item = (e.NewItems[i] as Notify);

                if(item != null)
                    item.PropertyChanged += CardModel_PropertyChanged;
            }
        }

        private void CardModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(Card.number))
            {
                var card = (sender as Card);
                if (card == null)
                    return;

                var findCard = cardSets.Where(x => x.number == card.number).FirstOrDefault();
                if (findCard == null)
                    return;

                card.uuid = findCard.uuid;
                //card.number = findCard.number;
                card.scryfallId = findCard.identifiers.scryfallId;
                card.cmc = findCard.convertedManaCost;
                card.name = findCard.name;
                card.set = findCard.setCode;
            }
        }

        public async Task loadSets()
        {
            var t = await JSON.loadJsonFromURIAsync<SetList[]>(@"https://mtgjson.com/api/v5/SetList.json");
            if(t != null)
                sets = new ObservableCollection<SetList>(t.ToList());
        }

        #region Sets
        private ObservableCollection<SetList> _sets = new ObservableCollection<SetList>();
        public ObservableCollection<SetList> sets { get => _sets; private set { _sets = value; OnPropertyChanged(); } }
        #endregion

        #region Selected Set
        private SetList? _selectedSet;
        public SetList? selectedSet { get => _selectedSet; set { _selectedSet = value; OnPropertyChanged(); } }
        #endregion

        #region Card Set
        private ObservableCollection<CardSet> _cardSets = new ObservableCollection<CardSet>();
        public ObservableCollection<CardSet> cardSets { get => _cardSets; private set { _cardSets = value; OnPropertyChanged(); } }
        #endregion

        #region My Cards
        private ObservableCollection<Card> _myCards = new ObservableCollection<Card>();
        public ObservableCollection<Card> myCards { get => _myCards; private set { _myCards = value; OnPropertyChanged(); } }
        #endregion

        #region Selected Card
        private Card? _selectedCard;
        public Card? selectedCard
        {
            get => _selectedCard;
            set { _selectedCard = value; OnPropertyChanged(); }
        }
        #endregion

        #region Load Card Database
        private ICommand loadCardDatabase;
        private bool canExecuteLoadCardDatabase { get => !(selectedSet == null); }
        public ICommand LoadCardDatabase
        {
            get => loadCardDatabase;
            set => loadCardDatabase = value;
        }

        private void LoadCardDatabaseFromMTGJson(object obj)
        {
            var t = JSON.loadJsonFromURI<Set>($"https://mtgjson.com/api/v5/{selectedSet?.code}.json");
            cardSets = new ObservableCollection<CardSet>(t.cards.ToList());
        }
        #endregion

        #region Load & Save
        private ICommand loadCSV;
        private bool canExecuteLoadCSV { get => false; } // CHANGE LATER
        public ICommand LoadCSV
        {
            get => loadCSV;
            set => loadCSV = value;
        }
        
        private void LoadCSVFromFile(object obj)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Comma Separated Values|*.csv";
            var dialog = ofd.ShowDialog();

            if(dialog.GetValueOrDefault() == true)
            {

            }
        }

        private ICommand saveCSV;
        private bool canExecuteSaveCSV { get => (myCards.Count > 0); }
        public ICommand SaveCSV
        {
            get => saveCSV;
            set => saveCSV = value;
        }

        private void SaveCSVToFile(object obj)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Comma Separated Values|*.csv";
            var res = sfd.ShowDialog();
            if (res == null)
                return;

            if (res.Value)
            {
                var csv = new StringBuilder();
                myCards.ToList().ForEach(card =>
                {
                    csv.Append($"\"{card.quantity}\",")
                       .Append($"\"{card.name}\",")
                       .Append($"\"{card.set}\",")
                       .Append($"\"{card.foil}\",")
                       .Append($"\"{card.number}\",")
                       .Append($"\"{card.scryfallId}\"")
                       .AppendLine();
                });

                File.WriteAllText(sfd.FileName, csv.ToString());
            }
        }
        #endregion
    }
}
