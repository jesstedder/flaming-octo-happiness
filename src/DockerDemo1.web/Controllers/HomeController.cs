using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace DockerDemo1.web.Controllers
{
    public class HomeController : Controller
    {
		private readonly Models.CallTreeDbContext _db;
		public HomeController(Models.CallTreeDbContext x)
		{
			_db = x;
		}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

		public IActionResult Logs()
		{
			return View(_db.NotificationLogs.ToList());
		}
    }
}