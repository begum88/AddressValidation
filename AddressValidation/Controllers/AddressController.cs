using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddressValidation.DAL;

namespace AddressValidation.Controllers
{
      
    public class AddressController : Controller
    {
        
        //
        // GET: /Address/
        public ActionResult Index()
        {
            //Create db context object here 
            AddressValidationDBEntities _db = new AddressValidationDBEntities();
            //Get the value from database and then set it to ViewBag to pass it View
            IEnumerable<SelectListItem> items = _db.Sehirler.Select(c => new SelectListItem
            {
                Value = c.SehirAdi,
                Text = c.SehirAdi

            });
            ViewBag.sehir = items;

            return View();
                
            
        }
	}
}