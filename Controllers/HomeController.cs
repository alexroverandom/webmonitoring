using Microsoft.AspNetCore.Mvc;

namespace WebMonitoring.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Test() {
			return View();
		}
	}
}
