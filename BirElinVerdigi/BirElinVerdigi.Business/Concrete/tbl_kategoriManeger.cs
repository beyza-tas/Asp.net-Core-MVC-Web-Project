using BirElinVerdigi.Business.Abstract;
using BirElinVerdigi.DataAccess.Abstract;
using BirElinVerdigi.Entity.Concrete;
using System;
using System.Collections.Generic;

namespace BirElinVerdigi.Business.Concrete
{
    public class tbl_kategoriManeger : Itbl_kategoriService
    {
        private Itbl_kategoriDal _tblKategoriDal;
        public tbl_kategoriManeger(Itbl_kategoriDal tblKategoriDal)
        {
            _tblKategoriDal = tblKategoriDal;
        }
        public void Add(tbl_kategori tblKategori)
        {
            _tblKategoriDal.Add(tblKategori);
        }

        public void Delete(tbl_kategori tblKategori)
        {
            _tblKategoriDal.Delete(tblKategori);
        }

        public tbl_kategori Get(int tblkategoriId)
        {
            return _tblKategoriDal.Get(x => x.kategoriID == tblkategoriId);
        }

        public List<tbl_kategori> GetAll()
        {
            return _tblKategoriDal.GetList();
        }

        public void Update(tbl_kategori tblKategori)
        {
            _tblKategoriDal.Update(tblKategori);
        }
    }
}
