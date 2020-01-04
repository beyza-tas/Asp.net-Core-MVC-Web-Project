using BirElinVerdigi.Business.Abstract;
using BirElinVerdigi.DataAccess.Abstract;
using BirElinVerdigi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirElinVerdigi.Business.Concrete
{
    public class tbl_uyeRolManeger : Itbl_uyeRolService
    {
        private Itbl_uyeRolDal _tblUyeRolDal;
        public tbl_uyeRolManeger(Itbl_uyeRolDal tblUyeRolDal)
        {
            _tblUyeRolDal = tblUyeRolDal;
        }
        public void Add(tbl_uyeRol UyeRolDal)
        {
            _tblUyeRolDal.Add(UyeRolDal);
        }

        public void Delete(tbl_uyeRol UyeRolDal)
        {
            _tblUyeRolDal.Delete(UyeRolDal);
        }

        public tbl_uyeRol Get(int UyeRolDalId)
        {
            return _tblUyeRolDal.Get(x => x.uyeRolID == UyeRolDalId);
        }

        public List<tbl_uyeRol> GetAll()
        {
            return _tblUyeRolDal.GetList();
        }

        public void Update(tbl_uyeRol UyeRolDal)
        {
            _tblUyeRolDal.Update(UyeRolDal);
        }
    }
}
