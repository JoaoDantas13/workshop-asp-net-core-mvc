using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;
using WebMvc.Models.ViewModels;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //Chama a ação ex : ../home/index
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Aplicativo Salles Web MVC do Curso C #.";
            ViewData["Professor"] = "João Vitor";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
