using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KudMVCapp.Controllers
{
    public class HomeController : Controller
    {
        //public List<string> Index(string id, string name)
        public ViewResult Index()
        {
            
            //ViewBag.Countries = new List<string>()
            ViewData["Countries"] = new List<string>
           {
               "India", "US", "UK", "Canada"
           };
            return View();
            // return typeof(Controller).Assembly.GetName().Version.ToString() + "Welcome to MVC App " + id + Request.QueryString[ "name"] + name; 
        }

        public string GetDetails()
        {
            return "GetDetails invoked";
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
}