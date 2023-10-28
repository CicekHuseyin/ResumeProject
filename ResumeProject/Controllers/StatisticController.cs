using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
	public class StatisticController : Controller
	{
		DbResumeeEntities db = new DbResumeeEntities();

		public ActionResult Index()
		{
			//ViewBag.skillCount = db.tbl_skill.Count();
			ViewBag.countProjeTalebi = db.ProjeTalebiCount().FirstOrDefault();
			ViewBag.technologyCount = db.tbl_technology.Count();
			ViewBag.csharpValue = db.tbl_technology.Where(x => x.TechnologyTitle == "C# Programlama Dili").Select(y => y.TechnologyValue).FirstOrDefault();
			//Select istenilen değeri verir.FirstOrDefault da filtrelemeden gelen tek bir değer döndürür.
			ViewBag.contactCount = db.tbl_contact.Count();
			ViewBag.subjectTesekkur = db.tbl_contact.Where(x => x.Subject == 1).Count();
			ViewBag.sumTechnologyValue = db.tbl_technology.Sum(x => x.TechnologyValue);
			ViewBag.avarageTechnologyValue = db.tbl_technology.Average(x => x.TechnologyValue);
			ViewBag.getBy5Id = db.tbl_skill.Where(x => x.SkillId == 5).Select(y => y.SkillTitle).FirstOrDefault();
			ViewBag.maxtechnologyValue = db.tbl_technology.Max(x => x.TechnologyValue);
			return View();
		}
	}
}