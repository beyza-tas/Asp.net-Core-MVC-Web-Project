using BirElinVerdigi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirElinVerdigi.Business.Abstract
{
    public interface Itbl_uyelerService
    {
        tbl_uyeler Get(int tblUyeler);
        List<tbl_uyeler> GetAll();
        void Add(tbl_uyeler tblUyeler);
        void Update(tbl_uyeler tblUyeler);
        void Delete(tbl_uyeler tblUyeler);
        tbl_uyeler GetForLogin(string kullaniciAdi, string sifre);
    }
}
