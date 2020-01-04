using BirElinVerdigi.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace BirElinVerdigi.Entity.Concrete
{
    public class tbl_ilan : IEntity 
    {
        [Key]
        public int ilanID { get; set; }

        public string ilanBaslik { get; set; }

        public string ilanBilgi { get; set; }

        public int kategoriID { get; set; }

        public int ilanRolID { get; set; }

        public int ilID { get; set; }


    }
}
