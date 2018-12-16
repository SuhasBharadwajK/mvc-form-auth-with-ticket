using MVC4FormsAuth.Types.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4FormsAuth.Web.Controllers
{
    public class HomeController : Controller
    {
        //[AllowAnonymous]
        [LogonAuthorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}
