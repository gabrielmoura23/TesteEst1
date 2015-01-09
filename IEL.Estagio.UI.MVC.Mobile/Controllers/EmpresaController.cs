using IEL.Estagio.Application.Interfaces;
using IEL.Estagio.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IEL.Estagio.UI.MVC.Mobile.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaAppService _empresaApp;

        public EmpresaController(
            IEmpresaAppService empresaApp)
        {
            _empresaApp = empresaApp;
        }

        // GET: Vaga
        public ActionResult Index()
        {
            var empresaViewModel = _empresaApp.GetAll();

            //var vagaViewModel2 = _empresaApp.BuscarPorNome("a");

            foreach (EmpresaViewModel v in empresaViewModel)
            {
                ICollection<VagaViewModel> lVaga = v.Vaga;
                //int a = v.Vaga.Count();
            }

            return View(empresaViewModel);
        }

       
    }
}
