using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
	public class SkillController : Controller
	{
		DbResumeeEntities db = new DbResumeeEntities();
		public ActionResult Index()
		{
			var values = db.tbl_skill.ToList();
			return View(values);
		}
		[HttpGet]
		public ActionResult AddSkill()
		{
			return View();
		}
		[HttpPost]
		public ActionResult AddSkill(tbl_skill p)
		{
			db.tbl_skill.Add(p);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult DeleteSkill(int id)
		{
			var value = db.tbl_skill.Find(id);
			db.tbl_skill.Remove(value);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult UpdateSkill(int? id)
		{
			var values = db.tbl_skill.Find(id);
			return View(values);
		}
		[HttpPost]
		public ActionResult UpdateSkill(tbl_skill p)
		{
			var value = db.tbl_skill.Find(p.SkillId);
			value.SkillTitle = p.SkillTitle;
			value.SkillIcon = p.SkillIcon;
			value.SkillDescription = p.SkillDescription;
			db.SaveChanges();
			return RedirectToAction("Index");
		}
		


	}
}