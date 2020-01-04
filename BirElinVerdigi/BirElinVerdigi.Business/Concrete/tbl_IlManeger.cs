using BirElinVerdigi.Business.Abstract;
using BirElinVerdigi.DataAccess.Abstract;
using BirElinVerdigi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirElinVerdigi.Business.Concrete
{
    public class tbl_IlManeger : Itbl_IlService
    {
        private Itbl_IIDal _tblIlDal;
        public tbl_IlManeger(Itbl_IIDal tblIlDal)
        {
            _tblIlDal = tblIlDal;
        }
        public void Add(tbl_Il tblIlDal)
        {
            _tblIlDal.Add(tblIlDal);
        }

        public void Delete(tbl_Il tblIlDal)
        {
            _tblIlDal.Delete(tblIlDal);
        }

        public tbl_Il Get(int tblIlDalId)
        {
            return _tblIlDal.Get(x => x.ilID == tblIlDalId);
        }

        public List<tbl_Il> GetAll()
        {
            return _tblIlDal.GetList();
        }

        public void Update(tbl_Il tblIlDal)
        {
            _tblIlDal.Update(tblIlDal);
        }
    }
}
