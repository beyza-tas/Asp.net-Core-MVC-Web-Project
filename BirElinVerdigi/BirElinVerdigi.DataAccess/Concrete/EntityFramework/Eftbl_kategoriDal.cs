using BirElinVerdigi.Core.DataAccess.EntityFramework;
using BirElinVerdigi.DataAccess.Abstract;
using BirElinVerdigi.Entity.Concrete;

namespace BirElinVerdigi.DataAccess.Concrete.EntityFramework
{
    public class Eftbl_kategoriDal : EfEntityRepositoryBase<tbl_kategori, Context> , Itbl_kategoriDal
    {
    }
}
