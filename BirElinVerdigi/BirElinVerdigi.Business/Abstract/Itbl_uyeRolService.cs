using BirElinVerdigi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirElinVerdigi.Business.Abstract
{
    public interface Itbl_uyeRolService
    {
        tbl_uyeRol Get(int tblUyeRol);
        List<tbl_uyeRol> GetAll();
        void Add(tbl_uyeRol tblUyeRol);
        void Update(tbl_uyeRol tblUyeRol);
        void Delete(tbl_uyeRol tblUyeRol);
    }
}
