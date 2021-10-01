using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;


namespace WebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamentos> list = new List<Departamentos>();
            list.Add(new Departamentos { Id = 1, Name = "Eletronicos" });
            list.Add(new Departamentos { Id = 2, Name = "Estilo" });

            return View(list);
        }
    }
}