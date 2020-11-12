using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESIDUOS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
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

        public IActionResult Registrarse()
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

        public IActionResult Capacitate()
        {
            return View();
        }
    }
}
