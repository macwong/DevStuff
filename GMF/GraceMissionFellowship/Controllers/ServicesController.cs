using System.Web.Mvc;
using GraceMissionFellowship.Helpers;
using GraceMissionFellowship.Models;

namespace GraceMissionFellowship.Controllers
{
	public class ServicesController : Controller
	{
		//
		// GET: /Service/

		public ActionResult Index()
		{
			PageModel vm = new PageModel(PageType.Services);
			return View("Index", vm);
		}
	}
}