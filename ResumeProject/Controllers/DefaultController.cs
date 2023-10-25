using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
	public class DefaultController : Controller
	{
		DbResumeeEntities db = new DbResumeeEntities();
		public PartialViewResult PartialScript()
		{
			return PartialView();
		}
		public PartialViewResult PartialFooter()
		{
			return PartialView();
		}
		public PartialViewResult PartialBrands()
		{
			return PartialView();
		}
		public PartialViewResult PartialProjects()
		{
			return PartialView();
		}
		public PartialViewResult PartialCounter()
		{
			ViewBag.skillCount = db.tbl_skill.Count();
			ViewBag.serviceCount = db.tbl_service.Count();
			ViewBag.avgTechnologyValues = db.tbl_technology.Average(x => x.TechnologyValue);
			ViewBag.happyCustomer = 38;
			return PartialView();
		}
		public PartialViewResult PartialTechnology()
		{
			var values = db.tbl_technology.ToList();
			return PartialView(values);
		}
		public PartialViewResult PartialService()
		{
			var values = db.tbl_service.ToList();
			return PartialView(values);
		}
		public PartialViewResult PartialAbout()
		{
			var values = db.tbl_profile.ToList();
			return PartialView(values);
		}
		public ActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialHeader()
		{
			return PartialView();
		}
		public PartialViewResult PartialNavbar()
		{
			return PartialView();
		}
		public PartialViewResult PartialFeature()
		{
			return PartialView();
		}

	}
}