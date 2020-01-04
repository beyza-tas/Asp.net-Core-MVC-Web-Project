using BirElinVerdigi.Core.DataAccess.EntityFramework;
using BirElinVerdigi.DataAccess.Abstract;
using BirElinVerdigi.Entity.Concrete;

namespace BirElinVerdigi.DataAccess.Concrete.EntityFramework
{
   public class Eftbl_uyelerDal : EfEntityRepositoryBase<tbl_uyeler, Context>, Itbl_uyelerDal
    {
    }
}
