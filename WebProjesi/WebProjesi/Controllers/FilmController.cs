using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using WebProjesi.Data;
using WebProjesi.Models;

namespace WebProjesi.Controllers
{   
    
    public class FilmController : Controller
    {

        private readonly ApplicationDBContext _db;
       
        
        public FilmController(ApplicationDBContext db)
        {
            _db = db;
            
        }
        
        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            
            
            IEnumerable<Film> objList = _db.Filmler;
			return View(objList);
            
			
        }

        public IActionResult kullaniciFilmler()
        {
            IEnumerable<Film> objList = _db.Filmler;
            return View(objList);
        }

        public IActionResult İletisim()
        {
            return View();
        }
        public IActionResult FilmYorum()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult FilmYorum(FilmYorumlar obj)
        {
            if (ModelState.IsValid)
            {
                _db.FilmYorumlari.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        
        public IActionResult Giris()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Film obj)
        {
            if (ModelState.IsValid)
            {
                _db.Filmler.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.Filmler.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]

        public IActionResult postDelete(int? id)
        {
            var obj = _db.Filmler.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.KullaniciKataloglar.RemoveRange(_db.KullaniciKataloglar.Where(x => x.filmNumara == id));
            _db.FilmYorumlari.RemoveRange(_db.FilmYorumlari.Where(x => x.FilmNumara == id));
            _db.Filmler.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Update(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.Filmler.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        //Post-Update Metodu
        [HttpPost]

        public IActionResult Update(Film obj)
        {
            if (ModelState.IsValid)
            {
                _db.Filmler.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(obj);
        }

        public IActionResult Details(int? id)
        {
            IEnumerable<FilmYorumlar> yorumList = _db.FilmYorumlari;

            
            if (id==0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.Filmler.Find(id);
            DetayveYorum detay = new DetayveYorum();
            detay.FilmYorumlar = yorumList.Where(i => i.FilmNumara == id);
            detay.film = obj;
            
            return View(detay);
        }

        [HttpPost]
        public IActionResult Details(int id,FilmYorumlar postYorum)
        {
            
            postYorum.FilmNumara = id;
            postYorum.Kullanici = User.Identity.Name;
            postYorum.Id = 0;
            postYorum.puan = "0";



             
            
                _db.FilmYorumlari.Add(postYorum);
                _db.SaveChanges();
                if (User.IsInRole("Admin"))
                {
                    return RedirectToAction("index", "film");
                }
                else
                {
                    return RedirectToAction("kullanicifilmler", "film");
                }
            


           

            if (id == 0 || id == null)
            {
                return NotFound();
            }
           
        }

        public IActionResult KatalogEkle(int? id)
        {

            var obj = _db.Filmler.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult KatalogEkle(int id)
        {
            var obj = _db.Filmler.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            var katalog = new Kataloglar();
            katalog.filmNumara = id;
            katalog.kullaniciAdi = User.Identity.Name;

            _db.KullaniciKataloglar.Add(katalog);
            _db.SaveChanges();
            return RedirectToAction("kullanicifilmler", "film");

        }

        public IActionResult Katalogum()
        {
            KatalogveFilm birlesim = new KatalogveFilm();
            IEnumerable<Kataloglar> katalog = _db.KullaniciKataloglar;
            
            birlesim.kataloglar = katalog.Where(x => x.kullaniciAdi == User.Identity.Name);            
            birlesim.filmler = _db.Filmler;
            return View(birlesim);
        }

        public IActionResult KatalogSil(int? id)
        {
            var obj = _db.Filmler.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult KatalogSil(int id)
        {
            var katalog = new Kataloglar();
            IEnumerable<Kataloglar> kataloglar = _db.KullaniciKataloglar;
            var katalogid = kataloglar.Where(x => x.kullaniciAdi == User.Identity.Name && x.filmNumara == id).FirstOrDefault();
            
            katalog = _db.KullaniciKataloglar.Find(katalogid.Id);
            
            _db.KullaniciKataloglar.Remove(katalog);
            _db.SaveChanges();
            return RedirectToAction("katalogum", "film");
        }

        public IActionResult YorumSil(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult YorumSil(int id)
        {
            var obj = _db.FilmYorumlari.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.FilmYorumlari.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("kullanicifilmler", "film");
        }

        public IActionResult filmAksiyon()
        {

            IEnumerable<Film> filmler = _db.Filmler;
            return View(filmler);
        }

        public IActionResult filmMacera()
        {

            IEnumerable<Film> filmler = _db.Filmler;
            return View(filmler);
        }

        public IActionResult filmBKurgu()
        {

            IEnumerable<Film> filmler = _db.Filmler;
            return View(filmler);
        }

        public IActionResult filmRomantik()
        {

            IEnumerable<Film> filmler = _db.Filmler;
            return View(filmler);
        }

    }
}