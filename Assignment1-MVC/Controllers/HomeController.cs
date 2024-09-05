using Microsoft.AspNetCore.Mvc;

namespace Assignment1_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View("AllMovies");
            return View();

        }

        public IActionResult AboutUs()
        {
            
            return View();

        }
        public IActionResult ContactUs()
        {

            return View();

        }
        public IActionResult Privacy()
        {

            return View();

        }
    }
}
