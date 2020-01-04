using BirElinVerdigi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirElinVerdigi.Business.Abstract
{
    public interface Itbl_IlService
    {
        tbl_Il Get(int tblIl);
        List<tbl_Il> GetAll();
        void Add(tbl_Il tblIl);
        void Update(tbl_Il tblIl);
        void Delete(tbl_Il tblIl);
    }
}
