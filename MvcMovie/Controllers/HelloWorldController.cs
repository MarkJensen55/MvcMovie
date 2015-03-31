using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld

        public ActionResult index()
        {
            return View();

        }
        
        // GET HelloWorld/Welcome/
        // removed exploration changes
        // Changed to use view
        public ActionResult Welcome(string name = "Stephan", int numtimes = 2)
        {
            ViewBag.message = "Hello " + name;
            ViewBag.NumTimes = numtimes;

            return View();
        }
    }
}