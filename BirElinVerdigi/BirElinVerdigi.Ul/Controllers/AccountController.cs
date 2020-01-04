using BirElinVerdigi.Business.Abstract;
using BirElinVerdigi.Entity.Concrete;
using BirElinVerdigi.Ul.Models;
using Microsoft.AspNetCore.Mvc;

namespace BirElinVerdigi.Ul.Controllers
{
    public class AccountController : Controller
    {
        private Itbl_uyelerService _uyelerService;
        public AccountController(Itbl_uyelerService uyelerService)
        {
            _uyelerService = uyelerService;
        }
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            tbl_uyeler loginData = _uyelerService.GetForLogin(loginViewModel.KullaniciAdi, loginViewModel.Sifre);
            if (loginData != null)
            {
                return RedirectToAction("Anasayfa", "Home");
            }
            TempData.Add("hata", "Tekrar Deneyin!");
            return RedirectToAction("Hakkımızda", "Home");
        }
    }
}
