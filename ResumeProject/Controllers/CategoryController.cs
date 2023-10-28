using ResumeProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
	public class CategoryController : Controller
	{
		DbResumeeEntities db = new DbResumeeEntities();
		public ActionResult Index()
		{
			var values = db.tbl_category.ToList();
			return View(values);
		}
		[HttpGet]
		public ActionResult AddCategory()
		{
			return View();
		}
		[HttpPost]
		public ActionResult AddCategory(tbl_category p)
		{
			var values = db.tbl_category.Add(p);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult DeleteCategory(int id)
		{
			var values = db.tbl_category.Find(id);
			db.tbl_category.Remove(values);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult UpdateCategory(int id)
		{
			var values = db.tbl_category.Find(id);
			return View(values);
		}
		[HttpPost]
		public ActionResult UpdateCategory(tbl_category p)
		{
			var values = db.tbl_category.Find(p.CategoryId);
			values.CategoryName = p.CategoryName;
			db.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult GetMessageBySubject(int id)
		{
			var values = db.tbl_contact.Where(x => x.Subject == id).ToList();
			return View(values);
		}

	}
}