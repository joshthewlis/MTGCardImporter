using MTGCardImporter.Base;
namespace MTGCardImporter.Models
{
    class Card : Notify
    {

        private uint _quantity = 1;
        private string _number = string.Empty;
        private bool _foil = false;
        private string _name = string.Empty;
        private string _set = string.Empty;
        private double _cmc = 0;
        private string _uuid = string.Empty;
        private string? _scryfallId;

        public string imageUrl { get => $"https://cards.scryfall.io/large/front/{scryfallId?.Substring(0, 1)}/{scryfallId?.Substring(1, 1)}/{scryfallId}.jpg"; }

        public uint quantity
        {
            get => _quantity;
            set { _quantity = value; OnPropertyChanged(); }
        }
        public string number
        {
            get => _number;
            set { _number = value; OnPropertyChanged(); }
        }
        public string foil
        {
            get => _foil ? "Foil" : "Normal";
            set { if (value == "Foil") _foil = true; else _foil = false; }
        }
        public string name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(); }
        }
        public string set
        {
            get => _set;
            set { _set = value; OnPropertyChanged(); }
        }
        public double cmc
        {
            get => _cmc;
            set { _cmc = value; OnPropertyChanged(); }
        }
        public string uuid
        {
            get => _uuid;
            set { _uuid = value; OnPropertyChanged(); }
        }
        public string? scryfallId
        {
            get => _scryfallId;
            set { _scryfallId = value; OnPropertyChanged(); }
        }

    }
}
