using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace copadomundoAUX.Controllers
{
    public class ErrorController : Controller
    {
        // GET: /Erro/Desconhecido 
        public ActionResult Desconhecido()
        {
            return View();
        }

        // GET: /Erro/PaginaNaoEncontrada
        public ActionResult PaginaNaoEncontrada()
        {
            return View();
        }


    }
}