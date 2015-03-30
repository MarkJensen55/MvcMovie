﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld

        public string index()
        {
            return "This is my <b>default</b> action ...";

        }
        
        // GET HelloWorld/Welcome/
        // removed exploration changes
        public string Welcome(string name = "Stephan", int id = 77)
        {
            //return "This is the Welcome action method..";
            return HttpUtility.HtmlEncode("Hello  " + name + " ID " + id);
        }
    }
}