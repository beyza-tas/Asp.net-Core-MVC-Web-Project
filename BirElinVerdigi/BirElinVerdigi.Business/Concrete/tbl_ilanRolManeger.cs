using BirElinVerdigi.Business.Abstract;
using BirElinVerdigi.DataAccess.Abstract;
using BirElinVerdigi.Entity.Concrete;
using System.Collections.Generic;

namespace BirElinVerdigi.Business.Concrete
{
    public class tbl_ilanRolManeger : Itbl_ilanRolService
    {
        private Itbl_ilanRolDal _tblIlanRolDal;
        public tbl_ilanRolManeger(Itbl_ilanRolDal tblIlanRolDal)
        {
            _tblIlanRolDal = tblIlanRolDal;
        }
        public void Add(tbl_ilanRol tblIlanRolDal)
        {
            _tblIlanRolDal.Add(tblIlanRolDal);
        }

        public void Delete(tbl_ilanRol tblIlanRolDal)
        {
            _tblIlanRolDal.Delete(tblIlanRolDal);
        }

        public tbl_ilanRol Get(int tblIlanRolDalId)
        {
            return _tblIlanRolDal.Get(x => x.ilanRolID == tblIlanRolDalId);
        }

        public List<tbl_ilanRol> GetAll()
        {
            return _tblIlanRolDal.GetList();
        }

        public void Update(tbl_ilanRol tblIlanRolDal)
        {
            _tblIlanRolDal.Update(tblIlanRolDal);
        }
    }
}
