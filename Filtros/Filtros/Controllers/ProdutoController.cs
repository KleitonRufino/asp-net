using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtros.Controllers
{
    using Models;
    using Filters;

    public class ProdutoController : Controller
    {
        private MyContext db = new MyContext();

        // GET: Produto
        [ElapsedTime]
        public ActionResult Index()
        {
            return View(db.Produtos.ToList());
        }

        [Authorize]
        public ActionResult Cadastrar()
        {
                return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Produtos.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "PosicaoInvalida")]
        public ActionResult Visualizar(int posicao) {
            List<Produto> produtos = db.Produtos.ToList();
            return View(produtos[posicao]);
        }



}
}