using BirElinVerdigi.Business.Abstract;
using BirElinVerdigi.DataAccess.Abstract;
using BirElinVerdigi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirElinVerdigi.Business.Concrete
{
    public class tbl_uyelerManeger : Itbl_uyelerService
    {
        private Itbl_uyelerDal _ItblUyelerDal;
        public tbl_uyelerManeger(Itbl_uyelerDal tblUyelerDal)
        {
            _ItblUyelerDal = tblUyelerDal;
        }
        public void Add(tbl_uyeler tblUyeler)
        {
            _ItblUyelerDal.Add(tblUyeler);
        }

        public void Delete(tbl_uyeler tblUyeler)
        {
            _ItblUyelerDal.Delete(tblUyeler);
        }

        public tbl_uyeler Get(int tblUyelerId)
        {
            return _ItblUyelerDal.Get(x => x.uyeID == tblUyelerId);
        }

        public List<tbl_uyeler> GetAll()
        {
            return _ItblUyelerDal.GetList();
        }

        public tbl_uyeler GetForLogin(string kullaniciAdi, string sifre)
        {
            return _ItblUyelerDal.Get(x => x.kullaniciAdi == kullaniciAdi && x.sifre == sifre);
        }

        public void Update(tbl_uyeler tblUyeler)
        {
            _ItblUyelerDal.Update(tblUyeler);
        }
    }
}
