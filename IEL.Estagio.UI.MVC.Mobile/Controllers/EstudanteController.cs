using System;
using System.Linq;
using System.Web.Mvc;
using IEL.Estagio.Application.Interfaces;
using IEL.Estagio.Application.ViewModels;

namespace IEL.Estagio.UI.MVC.Mobile.Controllers
{
    public class EstudanteController : Controller
    {
        private readonly IEstudanteAppService _estudanteApp;

        public EstudanteController(
            IEstudanteAppService estudanteApp)
        {
            _estudanteApp = estudanteApp;
        }

        // GET: Estudante
        public ViewResult Index()
        {
            var estudanteViewModel = _estudanteApp.GetAll();

            return View(estudanteViewModel);
        }


        // GET: Estudante/Details/5
        public ActionResult Details(Guid id)
        {
            var estudanteViewModel = _estudanteApp.GetById(id);
            //EstudanteViewModel.Enderecos = _enderecoApp.ObterPorEstudante(id);

            return View(estudanteViewModel);
        }

        // GET: Estudante/Create
        public ActionResult Create()
        {
            //ViewBag.EstadoId = new SelectList(_estadoApp.GetAll().OrderBy(e => e.Nome), "EstadoId", "Nome");
            //ViewBag.CidadeId = new SelectList(_cidadeApp.GetAll().OrderBy(c => c.Nome), "CidadeId", "Nome");

            return View();
        }

        // POST: Estudante/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstudanteViewModel estudante)
        {
            //ViewBag.EstadoId = new SelectList(_estadoApp.GetAll().OrderBy(e => e.Nome), "EstadoId", "Nome", estudanteEndereco.EstadoId);
            //ViewBag.CidadeId = new SelectList(_cidadeApp.GetAll().OrderBy(c => c.Nome), "CidadeId", "Nome", estudanteEndereco.CidadeId);

            if (ModelState.IsValid)
            {
                var result = _estudanteApp.Add(estudante);

                if (!result.IsValid)
                {
                    foreach (var validationAppError in result.Erros)
                    {
                        ModelState.AddModelError(string.Empty, validationAppError.Message);
                    }
                    return View(estudante);
                }

                return RedirectToAction("Index");
            }

            return View(estudante);
        }

        // GET: Estudante/Edit/5
        public ActionResult Edit(Guid id)
        {
            var estudanteViewModel = _estudanteApp.GetById(id);

            return View(estudanteViewModel);
        }

        // POST: Estudante/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstudanteViewModel estudanteViewModel)
        {
            if (ModelState.IsValid)
            {
                _estudanteApp.Update(estudanteViewModel);

                return RedirectToAction("Index");
            }

            return View(estudanteViewModel);
        }

        // GET: Estudante/Delete/5
        public ActionResult Delete(Guid id)
        {
            var estudanteViewModel = _estudanteApp.GetById(id);

            return View(estudanteViewModel);
        }

        // POST: Estudante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            var model = _estudanteApp.GetById(id);
            _estudanteApp.Remove(model);

            return RedirectToAction("Index");
        }
    }
}
