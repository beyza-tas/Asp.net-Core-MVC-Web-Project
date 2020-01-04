using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirElinVerdigi.Ul.Models
{
    public class KategorilerViewModel
    {
        public int kategoriID { get; set; }
        public string kategoriAd { get; set; }
        public int ilanID { get; set; }

        public string ilanBaslik { get; set; }

        public string ilanBilgi { get; set; }

        public int ilanRolID { get; set; }

        public int ilID { get; set; }
    }
}
