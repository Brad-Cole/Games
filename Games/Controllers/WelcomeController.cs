using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Games.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public string Index()
        {
            return "This is my <b>welcome</b> action...";
        }

        // 
        // GET: /Welcome/Hello/ 

        public string Hello(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
    }
}