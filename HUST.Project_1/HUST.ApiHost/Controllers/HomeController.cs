using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HUST.ApiHost.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {        
            return Content("--------------------------API SERVICE HUST--------------------------");
        }
    }
}
