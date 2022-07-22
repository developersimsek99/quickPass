using quickPassProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vonage.Request;
using Vonage;

namespace quickPassProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult nasilCalisir()
        {
            return View();
        }
        public ActionResult Page404()
        {
            
            if (Response.StatusCode == 404)
            {
                Response.TrySkipIisCustomErrors = true;
            }
            
            return View();
        }
        public ActionResult reportUs(ReportUs reportUs)
        {
            quickPassEntities db = new quickPassEntities();
            ReportUs report = new ReportUs();
            if (ModelState.IsValid)
            {
                db.reportUs.Add(reportUs);
                int KayitDurumu = db.SaveChanges();
                if (KayitDurumu > 0)
                {
                    ViewBag.MessageK = true;
                    ViewBag.MessageI = "Mesajınızı en kısa sürede dikkate alacağız.";
                    ViewBag.MessageS = "Öneriniz/Şikâyetiniz Başarılı Şekilde İletildi.";
                    
                }
                return RedirectToAction("Send", "SMSApi");
            }
            //SMS Api Operations

            return View();
            
        }
        
    }
}