using System.ComponentModel.DataAnnotations;

namespace BirElinVerdigi.Ul.Models
{
    public class LoginViewModel
    {
        [Required]
        public string KullaniciAdi { get; set; }
        [Required]
        public string Sifre { get; set; }

        [Required]
        public int uyeID { get; set; }
        [Required]
        public string kimlikNumarasi { get; set; }
        [Required]
        public string uyeAd { get; set; }
        [Required]
        public string uyeSoyad { get; set; }
        [Required]
        public string uyeEmail { get; set; }
        [Required]
        public string uyeProfilResmi { get; set; }
        [Required]
        public string kullaniciAdi { get; set; }
        [Required]
        public string sifre { get; set; }
        [Required]
        public int uyeRolID { get; set; }

        [Required]
        public int ilanID { get; set; }

    
    }
}
