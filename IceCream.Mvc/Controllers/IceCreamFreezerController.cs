using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IceCream.Lib;

namespace IceCream.Mvc.Controllers
{
	public class IceCreamFreezerController : Controller
	{
		//
		// GET: /IceCreamFreezer/

		public ActionResult Index()
		{
			var freezer = new IceCreamFreezer();
            return View();
        }

		public ActionResult SimpleView()
		{
			ViewBag.Title = "This is a simple view";
			ViewBag.BodyText = "Makin gud websites";
			return View();
		}

	}
}
