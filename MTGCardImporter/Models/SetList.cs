using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MTGCardImporter.Models
{
    class SetList
    {
        public double baseSetSize { get; set; } = 0;
        public string? block { get; set; }
        public string code { get; set; } = string.Empty; 
        public string? codeV3 { get; set; }
        public bool? isForeignOnly { get; set; }
        public bool isFoilOnly { get; set; }
        public bool? isNonFoilOnly { get; set; }
        public bool isOnlineOnly { get; set; }
        public bool? isPaperOnly { get; set; }
        public bool? isPartialPreview { get; set; }
        public string keyruneCode { get; set; } = string.Empty;
        public uint? mcmId { get; set; }
        public uint? mcmIdExtras { get; set; }
        public string? mcmName { get; set; }
        public string? mtgoCode { get; set; }
        public string name { get; set; } = string.Empty;
        public string? parentCode { get; set; }
        public string releaseDate { get; set; } = string.Empty;
        public SealedProduct[]? sealedProduct { get; set; }
        public uint? tcgplayerGroupId { get; set; }
        public uint totalSetSize { get; set; }
        public Translations translations { get; set; } = new Translations();
        public string type { get; set; } = string.Empty; 

    }
}
