using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESIDUOS.Models;
using RESIDUOS.Repositories;

namespace RESIDUOS.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(residuosContext ctx)
        {
            Context = ctx;
        }

        residuosContext Context;
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
            Usuario user = new Usuario();
            return View(user);
        }

        [HttpPost]
        public IActionResult Registrarse(Usuario user)
        {
            Repository<Usuario> repos = new Repository<Usuario>(Context);
            repos.Insert(user);
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
