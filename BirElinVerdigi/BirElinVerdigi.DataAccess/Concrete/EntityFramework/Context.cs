using BirElinVerdigi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BirElinVerdigi.DataAccess.Concrete.EntityFramework
{
    public class Context:DbContext
    {
    
        public DbSet<tbl_kategori> tbl_Kategori { get; set; }
        public DbSet<tbl_ilanRol> tbl_ilanRol { get; set; }
        public DbSet<tbl_Il> tbl_Il { get; set; }
        public DbSet<tbl_ilan> tbl_ilan { get; set; }
        public DbSet<tbl_uyeler> tbl_Uyeler { get; set; }
        public DbSet<tbl_uyeRol> tbl_UyeRol { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=BEYZATAS; Initial Catalog=BirElinVerdigi; Integrated Security=True;");
            }
        }


    }
}
