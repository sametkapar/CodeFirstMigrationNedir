using CodeFirstMigrationNedir.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstMigrationNedir.Controllers
{
    public class EtkinlikController : Controller
    {
        EtkinlikArsivModel db = new EtkinlikArsivModel();
        // GET: Etkinlik
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Etkinlik model, HttpPostedFileBase dosyaResim)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (dosyaResim != null)
                    {
                        FileInfo fi = new FileInfo(dosyaResim.FileName);
                        if (fi.Extension == ".jpg" || fi.Extension == ".png")
                        {
                            string isim = Guid.NewGuid().ToString()+ fi.Extension;
                            model.Resim = isim;
                            dosyaResim.SaveAs(Server.MapPath("../Assets/etkinlikResimleri/" +isim));
                            db.Etkinlikler.Add(model);
                            db.SaveChanges();
                        }
                        else
                        { 
                            ViewBag.hataMesaj = "Dosya uzantısı jpg veya png olmalıdır.";
                        }
                    }
                }
                catch
                {
                    ViewBag.hataMesaj = "Bir Hata Oluştu";
                }
            }
            return View(model);
        }
    }
}