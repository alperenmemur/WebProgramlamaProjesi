using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProjesi.Data;
using WebProjesi.Models;
using System.Web;

using Microsoft.AspNetCore.Http;

namespace WebProjesi.Controllers
{
    public class KayitController : Controller
    {
        private readonly ApplicationDBContext _db;
        public KayitController(ApplicationDBContext db){
            _db = db;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Kullanicilar obj)
        {
            if (ModelState.IsValid)
            {
                _db.Kullanicilar.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Film", new { area = "" });
            }

            return View(obj);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Kullanicilar obj)
        {

            if(ModelState.IsValid)
            {
               if(_db.Kullanicilar.Find(obj) != null)
                {
                    HttpContext.Session.SetString("session", obj.kullaniciAdi);
                }

            }

            return View();
        }
        
    }
}
