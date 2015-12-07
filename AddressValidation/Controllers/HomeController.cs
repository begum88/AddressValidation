using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddressValidation.DAL;

namespace AddressValidation.Controllers
{
    public class HomeController : Controller
    {
        AddressValidationDBEntities _db = new AddressValidationDBEntities();
        public ActionResult Index()
        {
            List<Sehirler> sehirler = _db.Sehirler.ToList();
            //ABC ilçesine ait şehirlerin hepsini getiren sorgu
            var s = sehirler.Where(x => x.Ilceler.Any(y => y.IlceAdi == "HASANBEYLİ")).ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}