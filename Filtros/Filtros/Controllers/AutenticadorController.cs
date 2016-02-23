using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Filtros.Controllers
{
    using Models;

    public class AutenticadorController : Controller
    {
        // GET: Autenticador
        public ActionResult Formulario()
        {
            return View();
        }

        public ActionResult Entrar(Usuario usuario)
        {
            if(usuario.Username != null && usuario.Password != null && usuario.Username.Equals("user") && usuario.Username.Equals("user"))
             {

                FormsAuthentication.SetAuthCookie(usuario.Username, false);
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                ViewBag.Mensagem = "usuário ou senha incorretas";
                return View();
            }
        }

        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Formulario");
        }
    }
}