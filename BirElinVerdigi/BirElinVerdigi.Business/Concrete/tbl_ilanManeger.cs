using BirElinVerdigi.Business.Abstract;
using BirElinVerdigi.DataAccess.Abstract;
using BirElinVerdigi.Entity.Concrete;
using System.Collections.Generic;

namespace BirElinVerdigi.Business.Concrete
{
    public class tbl_ilanManeger : Itbl_ilanService
    {
        private Itbl_ilanDal _Itbl_IlanDal;
        public tbl_ilanManeger(Itbl_ilanDal tblIlanDal)
        {
            _Itbl_IlanDal = tblIlanDal;
        }
        public void Add(tbl_ilan tblIlanDal)
        {
            _Itbl_IlanDal.Add(tblIlanDal);
        }

        public void Delete(tbl_ilan tblIlanDal)
        {
            _Itbl_IlanDal.Delete(tblIlanDal);
        }

        public tbl_ilan Get(int tblIlanDalId)
        {
            return _Itbl_IlanDal.Get(x => x.ilanID == tblIlanDalId);
        }

        public List<tbl_ilan> GetAll()
        {
            return _Itbl_IlanDal.GetList();
        }

        public List<tbl_ilan> GetPlaka(int id)
        {
            return _Itbl_IlanDal.GetList(x => x.ilID == id);
        }

        public void Update(tbl_ilan tblIlanDal)
        {
            _Itbl_IlanDal.Update(tblIlanDal);
        }
    }
}
