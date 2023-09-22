using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGCardImporter.Models
{
    class Meta
    {

        private string _date = string.Empty;
        private string _version = string.Empty;

        public string date { get => _date; set { _date = value; } }
        public string version { get => _version; set { _version = value; } }

    }
}
