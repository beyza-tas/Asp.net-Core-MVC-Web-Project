using BirElinVerdigi.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace BirElinVerdigi.Entity.Concrete
{
    public class tbl_kategori : IEntity
    {
        [Key]
        public int kategoriID { get; set; }
        public string kategoriAd { get; set; }
    }
}
