using BirElinVerdigi.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace BirElinVerdigi.Entity.Concrete
{
    public class tbl_uyeRol : IEntity
    {
        [Key]
        public int uyeRolID { get; set; }
        public string uyeRolAdi { get; set; }
    }
}
