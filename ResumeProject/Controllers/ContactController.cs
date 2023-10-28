using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class ContactController : Controller
    {
        DbResumeeEntities db = new DbResumeeEntities();
        public ActionResult Index()
        {
            var values = db.tbl_contact.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var values = db.tbl_contact.Find(id);
            db.tbl_contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SendMessage()
		{
            List<SelectListItem> values = (from x in db.tbl_category.ToList()
                                           select new SelectListItem 
                                           { 
                                               Text=x.CategoryName,
                                               Value=x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
		}
        [HttpPost]
        public ActionResult SendMessage(tbl_contact p)
        {
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.tbl_contact.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","Default");
        }
        public PartialViewResult PartialMap()
		{
            return PartialView();
		}
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
    }
}