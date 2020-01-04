using BirElinVerdigi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirElinVerdigi.Business.Abstract
{
    public interface Itbl_ilanService
    {
        tbl_ilan Get(int tblIlan);
        List<tbl_ilan> GetAll();
        void Add(tbl_ilan tblIlan);
        void Update(tbl_ilan tblIlan);
        void Delete(tbl_ilan tblIlan);

        List<tbl_ilan> GetPlaka(int id);
    }
}
