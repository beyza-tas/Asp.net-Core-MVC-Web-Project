using BirElinVerdigi.Business.Abstract;
using BirElinVerdigi.Entity.Concrete;
using BirElinVerdigi.Ul.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using BirElinVerdigi.Ul.AppCode;

namespace BirElinVerdigi.WebUl.Controllers
{
    public class HomeController : Controller
    {


        private Itbl_ilanService _tbl_IlanService;
        Itbl_uyelerService _tbl_UyelerService;

        public HomeController(Itbl_ilanService tbl_IlanService, Itbl_uyelerService tbl_UyelerService)
        {
            _tbl_IlanService = tbl_IlanService;
            _tbl_UyelerService = tbl_UyelerService;
        }

        public ActionResult Anasayfa()
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                    return View();
            }
            return RedirectToAction("Hakkımızda");
        }




        [Route("")]
        public ActionResult Hakkımızda()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            tbl_uyeler loginData = _tbl_UyelerService.GetForLogin(loginViewModel.KullaniciAdi, loginViewModel.Sifre);
            if (loginData != null)
            {
                string token = Guid.NewGuid().ToString() + "æ" + DateTime.Now;
                HttpContext.Session.Set("token", System.Text.Encoding.UTF8.GetBytes(token));
                ViewBag.Token = token;
                return RedirectToAction("Anasayfa", "Home");
            }
            TempData.Add("hata", "Tekrar Deneyin!");
            return RedirectToAction("Hakkımızda", "Home");
        }

        public async Task<ActionResult> kayitEkle(LoginViewModel loginViewModel)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://192.168.43.184:8000/process_get?TC=" + loginViewModel.kimlikNumarasi);
                var model = JsonConvert.DeserializeObject<IEnumerable<kontrol>>(
                    response.Content.ReadAsStringAsync().Result);
                string tc = null;
                string ad = null;
                string soyad = null;
                foreach (var item in model)
                {
                    tc = item.tc;
                    ad = item.ad;
                    soyad = item.soyad;
                }

                if (tc == null || tc == string.Empty || ad != loginViewModel.uyeAd || soyad != loginViewModel.uyeSoyad)
                {
                    TempData.Add("mesaj","Hatali tc kimlik numarasi girdiniz...");
                    return RedirectToAction("Hakkımızda", "Home");
                }

                tbl_uyeler tbl_Uyeler = new tbl_uyeler
                {
                    kullaniciAdi = loginViewModel.kullaniciAdi,
                    kimlikNumarasi = loginViewModel.kimlikNumarasi,
                    sifre = loginViewModel.sifre,
                    uyeAd = loginViewModel.uyeAd,
                    uyeEmail = loginViewModel.uyeEmail,
                    uyeSoyad = loginViewModel.uyeSoyad,
                    uyeID = loginViewModel.uyeID,
                    uyeRolID = loginViewModel.uyeRolID
                };
                _tbl_UyelerService.Add(tbl_Uyeler);
                return RedirectToAction("Anasayfa", "Home");
            }
        }

        [Route("Home/ilanlarım")]
        public ActionResult ilanlarim()
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    SqlDataReader sqlDataReader = Connection.ExecuteReader("Select * From kategori");
                    List<KategorilerViewModel> model = new List<KategorilerViewModel>();
                    while(sqlDataReader.Read())
                    {
                        model.Add(new KategorilerViewModel
                        {
                            kategoriID = Convert.ToInt32(sqlDataReader[0].ToString()),
                            kategoriAd = sqlDataReader[1].ToString(),
                            ilanID = Convert.ToInt32(sqlDataReader[2].ToString()),
                            ilanBaslik = sqlDataReader[3].ToString(),
                            ilanBilgi = sqlDataReader[4].ToString(),
                            ilanRolID = Convert.ToInt32(sqlDataReader[5].ToString()),
                            ilID = Convert.ToInt32(sqlDataReader[6].ToString())
                        });
                    }
                    return View(model);
                } 
            }
            return RedirectToAction("Hakkımızda");
            
        }


        public ActionResult ilanSil(int id)
        {
            tbl_ilan ilan = _tbl_IlanService.Get(id);
            _tbl_IlanService.Delete(ilan);
            TempData.Add("silindi", "İlan Silindi!");
            return RedirectToAction("ilanlarim");
        }


        public ActionResult ilanGüncelleme(tbl_ilan ilan)
        {
            if (ilan.ilanID == 0)
                _tbl_IlanService.Add(ilan);
            else
                _tbl_IlanService.Update(ilan);
            return RedirectToAction("ilanlarim");
        }

        public ActionResult ilanolustur()
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                    return View();
            }
            return RedirectToAction("Hakkımızda");
        }

        [HttpPost]
        public ActionResult ilanEkle(IlanOlusturViewModel ılanOlusturViewModel)
        {
            tbl_ilan tbl_Ilan = new tbl_ilan
            {
                ilanBilgi = ılanOlusturViewModel.ilanBilgi,
                ilanBaslik = ılanOlusturViewModel.ilanBaslik,
                ilanRolID = ılanOlusturViewModel.ilanRolID,
                ilID = ılanOlusturViewModel.ilID,
                kategoriID = ılanOlusturViewModel.kategoriID
            };
            _tbl_IlanService.Add(tbl_Ilan);
            return RedirectToAction("Anasayfa", "Home");
        }

        [Route("Home/ilanGoster/{id}")]
        public ActionResult ilanGoster(int id)
        {
            List<ilanGosterProcViewModel> ilan = new List<ilanGosterProcViewModel>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@il_Id", System.Data.SqlDbType.Int)
            };
            parameters[0].Value = id;
            SqlDataReader sqlDataReader = Connection.ExecuteReader("ilanGosterProc", System.Data.CommandType.StoredProcedure, parameters);
            while(sqlDataReader.Read())
            {
                ilan.Add(new ilanGosterProcViewModel
                {
                    kategoriID = Convert.ToInt32(sqlDataReader[0].ToString()),
                    kategoriAd = sqlDataReader[1].ToString(),
                    ilanID = Convert.ToInt32(sqlDataReader[2].ToString()),
                    ilanBaslik = sqlDataReader[3].ToString(),
                    ilanBilgi = sqlDataReader[4].ToString(),
                    ilanRolID = Convert.ToInt32(sqlDataReader[6].ToString()),
                    ilID = Convert.ToInt32(sqlDataReader[5].ToString()),
                    RolAd = sqlDataReader[7].ToString()
                });
            }
            return View(ilan);
        }



    }
}