using System.Web.Mvc;
using GraceMissionFellowship.Helpers;
using GraceMissionFellowship.Models;

namespace GraceMissionFellowship.Controllers
{
	public class ContactUsController : Controller
	{
		//
		// GET: /Contact/

		public ActionResult Index()
		{
			PageModel vm = new PageModel(PageType.ContactUs);
			return View("Index", vm);
		}
	}
}