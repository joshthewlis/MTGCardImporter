using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MTGCardImporter.Models
{
    class CardSet
    {

        public string? artist { get; set; }
        public string? asciiName { get; set; }
        public string[]? attractionLights { get; set; }
        public string[] availability { get; set; } = new string[0];
        public string[]? boosterTypes { get; set; }
        public string borderColor { get; set; } = string.Empty;
        public string[]? cardParts { get; set; }
        public string[] colorIdentity { get; set; } = new string[0];
        public string[]? colorIndicator { get; set; }
        public string[] colors { get; set; } = new string[0];
        public double convertedManaCost { get; set; }
        public string? defense { get; set; }
        public uint? edhrecRank { get; set; }
        public double? edhrecSaltiness { get; set; }
        public double? faceConvertedManaCost { get; set; }
        public string? faceFlavorName { get; set; }
        public double? faceManaValue { get; set; }
        public string? faceName { get; set; }
        public string[] finishes { get; set; } = new string[0];
        public string? flavorName { get; set; }
        public string? flavorText { get; set; }
        //public ForeignData[]? foreignData { get; set; }
        public string[]? frameEffects { get; set; }
        public string frameVersion { get; set; } = string.Empty;
        public string? hand { get; set; }
        public bool? hasAlternativeDeckLimit { get; set; }
        public bool? hasContentWarning { get; set; }
        public bool hasFoil { get; set; }
        public bool hasNonFoil { get; set; }
        public Identifiers identifiers { get; set; } = new Identifiers();
        public bool? isAlternative { get; set; }
        public bool? isFullArt { get; set; }
        public bool? isFunny { get; set; }
        public bool? isOnlineOnly { get; set; }
        public bool? isOversized { get; set; }
        public bool? isPromo { get; set; }
        public bool? isRebalanced { get; set; }
        public bool? isReprint { get; set; }
        public bool? isReserved { get; set; }
        public bool? isStarter { get; set; }
        public bool? isStorySpotlight { get; set; }
        public bool? isTextless { get; set; }
        public bool? isTimeshifted { get; set; }
        public string[]? keywords { get; set; }
        public string language { get; set; } = string.Empty;
        public string layout { get; set; } = string.Empty;
        //public LeadershipSkills? leadershipSkills { get; set; }
        //public Legalities legalities { get; set; }
        public string? life { get; set; }
        public string? loyalty { get; set; }
        public string? manaCost { get; set; }
        public double manaValue { get; set; }
        public string name { get; set; } = string.Empty;
        public string? number { get; set; }
        public string[]? originalPrintings { get; set; }
        public string? originalReleaseDate { get; set; }
        public string? originalText { get; set; }
        public string? originalType { get; set; }
        public string[]? otherFaceIds { get; set; }
        public string? power { get; set; }
        public string[]? printings { get; set; }
        public string[]? promoTypes { get; set; }
        //public PurchaseUrls purchaseUrls { get; set; }
        public string rarity { get; set; } = string.Empty;
        //public RelatedCards relatedCards { get; set; }
        public string[]? rebalancedPrintings { get; set; }
        //public Rulings[] rulings { get; set; }
        public string? securityStamp { get; set; }
        public string setCode { get; set; } = string.Empty;
        public string? side { get; set; }
        public string? signature { get; set; }
        public string[]? subsets { get; set; }
        public string[] subtypes { get; set; } = new string[0];
        public string[] supertypes { get; set; } = new string[0];
        public string? text { get; set; }
        public string? toughness { get; set; }
        public string type { get; set; } = string.Empty;
        public string[] types { get; set; } = new string[0];
        public string uuid { get; set; } = string.Empty;
        public string[]? variations { get; set; }
        public string? watermark { get; set; }

    }
}
