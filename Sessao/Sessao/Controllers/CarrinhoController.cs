using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sessao.Controllers
{
    using Models;
    public class CarrinhoController : Controller
    {
        // GET: Carrinho
        public ActionResult Index()
        {
            return View(this.PegaCarrinhoDaSessao());
        }

        public ActionResult Cancelar()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Produto");
        }

        public ActionResult Adicionar(int id = 0)
        {
            MyContext context = new MyContext();
            Produto p = context.Produtos.Find(id);
            if(p == null)
            {
                return HttpNotFound();
            }
            Carrinho carrinho = this.PegaCarrinhoDaSessao();
            carrinho.Produtos.Add(p);

            TempData["Mensagem"] = "Produto adicionado ao carrinho com sucesso!";
            return RedirectToAction("Index", "Produto");
        }

        public ActionResult Remover(int idx = 0)
        {
            Carrinho carrinho = this.PegaCarrinhoDaSessao();
            carrinho.Produtos.RemoveAt(idx);
            return RedirectToAction("Index", "Produto");
        }

        private Carrinho PegaCarrinhoDaSessao()
        {
           if(Session["Carrinho"] == null)
            {
                Session["Carrinho"] = new Carrinho();
            }
            return Session["Carrinho"] as Carrinho;
        }
    }
}