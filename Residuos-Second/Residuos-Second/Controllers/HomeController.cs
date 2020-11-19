using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESIDUOS.Repositories;
using Residuos_Second.Models;
using Residuos_Second.Models.ViewModels;
using Residuos_Second.Repositories;

namespace Residuos_Second.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Capacitate()
        {
            return View();
        }

        public IActionResult Capacitate3()
        {
            return View();
        }

        public IActionResult Capacitate2()
        {
            return View();
        }

        public IActionResult Evaluacion()
        {
            return View();
        }

        public IActionResult InicioSesion()
        {
            return View();
        }

        public IActionResult QuienesSomos()
        {
            return View();
        }

        public IActionResult Recompensas()
        {
            return View();
        }

        public IActionResult Registrarse()
        {
            residuosContext Context = new residuosContext();
            EscuelaRepository repos = new EscuelaRepository(Context);
            RegistrarseViewModels vm = new RegistrarseViewModels();
            vm.Escuelas = repos.GetAll();
            return View();
        }
        
        [HttpPost]
        public IActionResult Registrarse(RegistrarseViewModels vm)
        {

            return RedirectToAction("Index");
        }
    }
}
