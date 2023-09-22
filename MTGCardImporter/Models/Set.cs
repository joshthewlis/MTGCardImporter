using MTGCardImporter.Base;
using System.Collections.Generic;

namespace MTGCardImporter.Models
{
    class Set : Notify
    {

        public int baseSetSize { get; set; }
        public string? block { get; set; }
        public object? booster { get; set; }
        public CardSet[] cards { get; set; } = new CardSet[0];
        public uint? cardsphereSetId { get; set; }
        public string code { get; set; } = string.Empty;
        public string codeV3 { get; set; } = string.Empty;
        public bool? isForeignOnly { get; set; }
        public bool isFoilOnly { get; set; }
        public bool? isNonFoilOnly { get; set; }
        public bool isOnlineOnly { get; set; }
        public bool? isPaperOnly { get; set; }
        public bool? isPartialPreview { get; set; }
        public string keyruneCode { get; set; } = string.Empty;
        public string[] languages { get; set; } = new string[0];
        public uint? mcmId { get; set; }
        public uint? mcmIdExtras { get; set; }
        public string? mcmName { get; set; }
        public string? mtgoCode { get; set; }
        public string name { get; set; } = string.Empty;
        public string? parentCode { get; set; }
        public string releaseDate { get; set; } = string.Empty;
        public SealedProduct[]? sealedProduct { get; set; }
        public uint? tcgplayerGroupId { get; set; }
        public CardToken[] tokens { get; set; } = new CardToken[0]; 
        public string? tokenSetCode { get; set; }
        public uint totalSetSize { get; set; }
        public Translations translations { get; set; } = new Translations();
        public string type { get; set; } = string.Empty;

    }
}
