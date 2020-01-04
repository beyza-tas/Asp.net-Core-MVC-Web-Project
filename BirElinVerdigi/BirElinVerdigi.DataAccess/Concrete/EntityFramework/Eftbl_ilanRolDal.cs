using BirElinVerdigi.Core.DataAccess.EntityFramework;
using BirElinVerdigi.DataAccess.Abstract;
using BirElinVerdigi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirElinVerdigi.DataAccess.Concrete.EntityFramework
{
   public class Eftbl_ilanRolDal : EfEntityRepositoryBase<tbl_ilanRol , Context> , Itbl_ilanRolDal
    {
    }
}
