using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            FormQuestion question = new FormQuestion();
            return View(question);
        }

        public IActionResult Privacy(FormQuestion obj)
        {
            return View(obj);
        }
        public IActionResult submitQuestion(FormQuestion obj)
        {
          
            return RedirectToAction("Privacy",  obj); ;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
