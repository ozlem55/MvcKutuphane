﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class MesajlarController : Controller
    {
        // GET: Mesajlar
        DBKUTUPHANEEntities3 db = new DBKUTUPHANEEntities3();
        public ActionResult Index()
        {
            var uyemail = (string)Session["Mail"].ToString();
            var mesajlar = db.TBLMESAJLAR.Where(x => x.ALICI == uyemail.ToString()).ToList();
            return View(mesajlar);
        }
        public ActionResult Giden()
        {
            var uyemail = (string)Session["Mail"].ToString();
            var mesajlar = db.TBLMESAJLAR.Where(x => x.GONDEREN == uyemail.ToString()).ToList();
            return View(mesajlar);
        }
        [HttpGet]
        public ActionResult YeniMesaj()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMesaj(TBLMESAJLAR m)
        {
            var uyemail = (string)Session["Mail"].ToString();
            m.GONDEREN = uyemail.ToString();
            m.TARIH = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLMESAJLAR.Add(m);
            db.SaveChanges();
            return RedirectToAction("Giden", "Mesajlar");
        }
        public PartialViewResult Partial1()
        {
            var uyemail = (string)Session["Mail"].ToString();
            var gelensayisi = db.TBLMESAJLAR.Where(x => x.ALICI == uyemail).Count();
            var gidensayisi = db.TBLMESAJLAR.Where(x => x.GONDEREN == uyemail).Count();
            ViewBag.d1 = gelensayisi;
            ViewBag.d2 = gidensayisi;
            return PartialView();
        }
            
     
    }
}