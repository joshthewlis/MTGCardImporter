using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MTGCardImporter.Models
{
    class SealedProduct
    {

        public string? category { get; set; }
        public Identifiers identifiers { get; set; } = new Identifiers();
        public string name { get; set; } = string.Empty;
        public uint? productSize { get; set; }
        public PurchaseUrls purchaseUrls { get; set; } = new PurchaseUrls();
        public string? releaseDate { get; set; }
        public string? subtype { get; set; }
        public string uuid { get; set; } = string.Empty;

    }
}
