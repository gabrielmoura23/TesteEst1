using IEL.Estagio.Application.Interfaces;
using IEL.Estagio.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IEL.Estagio.UI.MVC.Mobile.Controllers
{
    public class VagaController : Controller
    {
        private readonly IVagaAppService _vagaApp;

        public VagaController(
            IVagaAppService vagaApp)
        {
            _vagaApp = vagaApp;
        }

        // GET: Vaga
        public ActionResult Index()
        {
            var vagaViewModel = _vagaApp.GetAll();

            //var vagaViewModel2 = _vagaApp.BuscarPorNome("a");


            foreach (VagaViewModel v in vagaViewModel)
            {
                EmpresaViewModel e = v.Empresa;
                //int a = v.Vaga.Count();
            }
            
            return View(vagaViewModel);
        }

        // GET: Vaga/Details/5
        public ActionResult Details(int id)
        {
            var vagaViewModel = _vagaApp.GetByIdTipoInteiro(id);
            return View(vagaViewModel);
        }

        // GET: Vaga/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudante/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VagaViewModel vaga)
        {
            //ViewBag.EstadoId = new SelectList(_estadoApp.GetAll().OrderBy(e => e.Nome), "EstadoId", "Nome", estudanteEndereco.EstadoId);
            //ViewBag.CidadeId = new SelectList(_cidadeApp.GetAll().OrderBy(c => c.Nome), "CidadeId", "Nome", estudanteEndereco.CidadeId);

            if (ModelState.IsValid)
            {
                var result = _vagaApp.Add(vaga);

                if (!result.IsValid)
                {
                    foreach (var validationAppError in result.Erros)
                    {
                        ModelState.AddModelError(string.Empty, validationAppError.Message);
                    }
                    return View(vaga);
                }

                return RedirectToAction("Index");
            }

            return View(vaga);
        }

        // GET: Vaga/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vaga/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vaga/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vaga/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
