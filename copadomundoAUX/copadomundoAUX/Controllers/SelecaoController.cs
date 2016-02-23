using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CopaDoMundo.Controllers
{
    using Models;

    [Authorize(Roles = "Administrador")]
    public class SelecaoController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Selecao
        public ActionResult Index()
        {
            return View(unitOfWork.SelecaoRepository.Selecoes);
        }

        // GET: Selecao
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Selecao selecao)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.SelecaoRepository.Adiciona(selecao);
                unitOfWork.Salva();
                return RedirectToAction("Index");
            }
           return View(selecao);
        }

        public ActionResult Delete(int id)
        {
            Selecao selecao = unitOfWork.SelecaoRepository.Busca(id);
            return View(selecao);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed (int id)
        {
            unitOfWork.SelecaoRepository.Remove(id);
            unitOfWork.Salva();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}