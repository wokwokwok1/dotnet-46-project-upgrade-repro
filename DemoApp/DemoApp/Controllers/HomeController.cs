using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeControllerService _service;

        public HomeController()
        {
            _service = new HomeControllerService();
        }

        public ActionResult Index()
        {
            return View(_service.Index());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class HomeIndexViewModel
    {
        public string PublicString { get; set; }
        public string PublicHash { get; set; }
    }

    public class HomeControllerService
    {
        public HomeIndexViewModel Index()
        {
            return new HomeIndexViewModel()
            {
                PublicString = "Hello World",
                PublicHash = getHashSHA256("Hello World")
            };
        }

        private string getHashSHA256(string text)
        {
            var bytes = Encoding.UTF8.GetBytes(text);
            var hasher = new SHA256Managed();
            var hash = hasher.ComputeHash(bytes);
            return hash.Aggregate(string.Empty, (current, x) => current + $"{x:x2}");
        }
    }
}