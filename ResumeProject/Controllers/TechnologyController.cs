using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models; 

namespace ResumeProject.Controllers
{
    public class TechnologyController : Controller
    {
        DbResumeeEntities db = new DbResumeeEntities();

        public ActionResult Index()
        {
            var values = db.tbl_technology.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTechnology()
		{
            return View();
		}
        [HttpPost]
        public ActionResult AddTechnology(tbl_technology p)
		{
            db.tbl_technology.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
		}
        public ActionResult DeleteTechnology(int id)
		{
            var value = db.tbl_technology.Find(id);
            db.tbl_technology.Remove(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTechnology(int id)
        {
            var value = db.tbl_technology.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTechnology(tbl_technology p)
        {
            var value = db.tbl_technology.Find(p.TehnologyId);
            value.TechnologyTitle = p.TechnologyTitle;
            value.TechnologyValue = p.TechnologyValue;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}