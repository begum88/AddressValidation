﻿using System;
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
            //Create db context object here 
            AddressValidationDBEntities _db = new AddressValidationDBEntities();
            //Get the value from database and then set it to ViewBag to pass it View
            IEnumerable<SelectListItem> items = _db.Sehirler.Select(c => new SelectListItem
            {
                Value = c.SehirId.ToString(),
                Text = c.SehirAdi

            });
            ViewBag.sehir = items;
            IEnumerable<SelectListItem> items2 = _db.Ilceler.Select(c => new SelectListItem
            {
                Value = c.ilceId,
                Text = c.IlceAdi

            });
            ViewBag.ılce = items2;
     

           
                
        }
       
        
        public ActionResult About()
        {
            ViewBag.Message = "Adres Kontrol Sitesi";

            return View();
        }

      
    }
}