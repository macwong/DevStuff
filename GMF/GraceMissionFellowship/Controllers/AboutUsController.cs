using System.Web.Mvc;
using GraceMissionFellowship.Helpers;
using GraceMissionFellowship.Models;

namespace GraceMissionFellowship.Controllers
{
	public class AboutUsController : Controller
	{
		//
		// GET: /About/

		public ActionResult Index()
		{
			PageModel vm = new PageModel(PageType.AboutUs);
			return View("Index", vm);
		}
	}
}