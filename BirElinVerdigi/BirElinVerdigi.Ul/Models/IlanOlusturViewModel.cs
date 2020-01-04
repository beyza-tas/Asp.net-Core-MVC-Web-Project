using System.ComponentModel.DataAnnotations;

namespace BirElinVerdigi.Ul.Models
{
    public class IlanOlusturViewModel
    {
        public int ilanID { get; set; }

        public string ilanBaslik { get; set; }

        public string ilanBilgi { get; set; }

        public int kategoriID { get; set; }

        public int ilanRolID { get; set; }

        public int ilID { get; set; }
    }
}
