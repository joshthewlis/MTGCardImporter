using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MTGCardImporter.Models
{
    class CardAtomic
    {

        public string? asciiName { get; set; }
        public string[]? attractionLights { get; set; }
        public string[] colorIdentity { get; set; } = new string[0];
        public string[]? colorIndicator { get; set; }
        public string[] colors { get; set; } = new string[0];
        public uint convertedManaCost { get; set; }
        public string? defense { get; set; }
        public uint? edhrecRank { get; set; }
        public uint? edhrecSaltiness { get; set; }
        public uint? faceConvertedManaCost { get; set; }
        public uint? faceManaValue { get; set; }
        public string? faceName { get; set; }
        public string? firstPrinting { get; set; }
        public ForeignData[]? foreignData { get; set; }
        public string? hand { get; set; }
        public bool hasAlternativeDeckLimit { get; set; }
        public Identifiers identifiers { get; set; } = new Identifiers();
        public bool? isFunny { get; set; }
        public bool? isReserved { get; set; }
        public string[]? keywords { get; set; }
        public string layout { get; set; } = string.Empty;
        public LeadershipSkills? leadershipSkills { get; set; }
        public Legalities legalities { get; set; } = new Legalities();
        public string? life { get; set; }
        public string? loyalty { get; set; }
        public string? manaCost { get; set; }
        public uint manaValue { get; set; }
        public string name { get; set; } = string.Empty;
        public string? power { get; set; }
        public string[]? printings { get; set; }
        public PurchaseUrls purchaseUrls { get; set; } = new PurchaseUrls();
        public RelatedCards relatedCards { get; set; } = new RelatedCards();
        public Rulings[] rulings { get; set; } = new Rulings[0];
        public string? side { get; set; }
        public string[]? subsets { get; set; }
        public string[] subtypes { get; set; } = new string[0];
        public string[] supertypes { get; set; } = new string[0];
        public string? text { get; set; }
        public string? toughness { get; set; }
        public string type { get; set; } = string.Empty;
        public string[] types { get; set; } = new string[0];

    }
}
