using BirElinVerdigi.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace BirElinVerdigi.Entity.Concrete
{
    public class tbl_ilanRol : IEntity
    {
        [Key]
        public int ilanRolID { get; set; }
        public string RolAd { get; set; }
    }
}
