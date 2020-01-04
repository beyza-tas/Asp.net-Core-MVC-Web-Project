using BirElinVerdigi.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace BirElinVerdigi.Entity.Concrete
{
    public class tbl_Il : IEntity 
    {
        [Key]
        public int ilID { get; set; }

        public string ilAdi { get; set; }
    }
}
