using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InjecaoDeDependencia.Controllers
{
    using Models;

    public class HomeController : Controller
    {
        readonly IMessage message;
        
        public HomeController(IMessage message)
        {
            this.message = message;
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = this.message.Message();
            return View();
        }
    }
}