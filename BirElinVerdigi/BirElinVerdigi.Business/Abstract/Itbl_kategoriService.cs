using BirElinVerdigi.Entity.Concrete;
using System.Collections.Generic;

namespace BirElinVerdigi.Business.Abstract
{
    public interface Itbl_kategoriService
    {
        tbl_kategori Get(int tblKategori);
        List<tbl_kategori> GetAll();
        void Add(tbl_kategori tblKategori);
        void Update(tbl_kategori tblKategori);
        void Delete(tbl_kategori tblKategori);
    }
}
