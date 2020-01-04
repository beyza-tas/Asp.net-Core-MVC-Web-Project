using BirElinVerdigi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirElinVerdigi.Business.Abstract
{
    public interface Itbl_ilanRolService
    {
        tbl_ilanRol Get(int tblIlanRol);
        List<tbl_ilanRol> GetAll();
        void Add(tbl_ilanRol tblIlanRol);
        void Update(tbl_ilanRol tblIlanRol);
        void Delete(tbl_ilanRol tblIlanRol);
    }
}
