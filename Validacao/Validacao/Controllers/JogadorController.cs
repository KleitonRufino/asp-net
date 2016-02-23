using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Validacao.Controllers
{
    using Models;
    public class JogadorController : Controller
    {
        // GET: Jogador
        public ActionResult Lista()
        {
            MyContext context = new MyContext();
            return View(context.Jogadores);
        }

        [HttpGet]
        public ActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastra(Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                MyContext context = new MyContext();
                context.Jogadores.Add(jogador);
                context.SaveChanges();
                return RedirectToAction("Lista");
            }
            else
            {
                return View("Cadastra", jogador);
            }
         
            
        }
    }
}