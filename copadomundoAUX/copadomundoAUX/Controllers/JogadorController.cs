using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CopaDoMundo.Controllers
{
    using Models;


    public class JogadorController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: Jogador
        public ActionResult Index()
        {
            return View(unitOfWork.JogadorRepository.Jogadores);
        }

        public ActionResult Create()
        {
            ViewBag.SelecaoId = new SelectList(unitOfWork.SelecaoRepository.Selecoes, "Id", "Pais");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.JogadorRepository.Adiciona(jogador);
                unitOfWork.Salva();
                return RedirectToAction("Index");
            }
            ViewBag.SelecaoId = new SelectList(unitOfWork.SelecaoRepository.Selecoes, "Id", "Pais");
            return View();
        }

        public ActionResult Delete(int id)
        {
            Jogador jogador = unitOfWork.JogadorRepository.Busca(1);
            return View(jogador);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            unitOfWork.JogadorRepository.Remove(id);
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