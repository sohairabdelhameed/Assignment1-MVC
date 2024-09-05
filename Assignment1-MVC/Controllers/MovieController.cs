
using Assignment1_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment1_MVC.Controllers
{
    public class MovieController : Controller
    {
       public IActionResult GetMovie(int id, string name,Employee employee)
       {
            //ContentResult contentResult = new ContentResult();

            //contentResult.Content = $"Movie with id:{id}";

            //return contentResult;
            //https://localhost:7102/Movie/GetMovie/10
            //https://localhost:7102/Movie/GetMovie?id=10&name=Abc
            //https://localhost:7102/Movie/GetMovie?id=10&name=Abc&employee.name=sohair
            return Content($"Movie with id:{id}");


        }

        //Action Binding //(Order Matters)
        //1.Form
        //2.Segment
        //3.Query String
        //4. File

        public IActionResult Index()
        {
            return Content("Hello");
        }
        //public ContentResult Index()
        //{
        //   // ContentResult result = new ContentResult();
        //   // result.Content = "Hello From Index";
        //   //// result.ContentType = "objrct/pdf";
        //   ///Another way:
        //    return Content("Hello","text/html");
        //}

        //public IActionResult Test()
        //{
        //    //RedirectResult result = new RedirectResult("https://localhost:7102/Movie/Index");
        //    //return result;
        //    //// https://localhost:7102/Movie/Index wrong in production
        //    //    // return Redirect("https://localhost:7102/Movie/Index");

        //   // return RedirectToAction(nameof(Index));
        //    return RedirectToRoute(new {Controller ="Movie" , action="Index"});
        //}




    }
}
