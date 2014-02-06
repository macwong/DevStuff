using System.Web.Mvc;
using GraceMissionFellowship.Helpers;
using GraceMissionFellowship.Models;

namespace GraceMissionFellowship.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			PageModel vm = new PageModel(PageType.Home);
			return View("Index", vm);
		}

		public ActionResult Test1()
		{
			return View();
		}

		public ActionResult Test2()
		{
			return View();
		}

		public ActionResult Test3()
		{
			return View();
		}
	}
}