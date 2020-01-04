using BirElinVerdigi.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace BirElinVerdigi.Entity.Concrete
{
    public class tbl_uyeler : IEntity
    {
        [Key]
        public int uyeID { get; set; }

        public string kimlikNumarasi { get; set; }

        public string uyeAd { get; set; }

        public string uyeSoyad { get; set; }

        public string uyeEmail { get; set; }

        public string kullaniciAdi { get; set; }

        public string sifre { get; set; }

        public int uyeRolID { get; set; }


        public int ilanID { get; set; }


    }
}
