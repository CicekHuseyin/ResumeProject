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
    }
}