using System.Web.Mvc;
using IceCream.Lib;

namespace IceCream.Mvc.Controllers
{
	public class IceCreamFreezerController : Controller
	{

		public ActionResult Index()
		{
			var freezer = new IceCreamFreezer();
			return Index(freezer);
		}

		public ActionResult SimpleView()
		{
			ViewBag.Title = "This is a simple view";
			ViewBag.BodyText = "Makin gud websites";
			return View();
		}

		private ActionResult Index(IceCreamFreezer freezer)
		{
			ViewBag.Title = freezer.Name;
			ViewBag.FreezerContents = freezer.Contents();
			return View();
		}


	}
}
