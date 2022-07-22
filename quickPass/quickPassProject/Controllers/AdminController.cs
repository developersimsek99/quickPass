using quickPassProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quickPassProject.Controllers
{
    public class AdminController : Controller
    {
        quickPassEntities db = new quickPassEntities();
        public ActionResult Index()
        {
            var model = db.reportUs.ToList();
            return View();
        }
        public ActionResult messageList()
        {
            var model = db.reportUs.ToList();
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var message = db.reportUs.Find(id);
            db.reportUs.Remove(message);
            db.SaveChanges();
            return RedirectToAction("messageList");
        }
    }
}