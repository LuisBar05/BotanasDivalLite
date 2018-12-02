using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BotanasDIVAL.Models;

namespace BotanasDIVAL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Solo unos cuantos datos adicionales acerca de este sitio.";

            return View();
        }

        public IActionResult Help()
        {
            ViewData["Message"] = "Llegaste aquí buscando ayuda, y eso es justo lo que hay.";

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "Última Actualización: 28 de Noviembre, 2018.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
