using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InspirateMobileWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace InspirateMobileWeb.Controllers
{
    public class CategoriaItemController : Controller
    {
        public IActionResult Index()
        {
            var listaModel = new List<CategoriaItem>();
            for (int i = 0; i < 100; i++)
            {
                listaModel.Add(new CategoriaItem
                {
                    Id = i,
                    Titulo = "Titulo " + i
                });
            }
            return View(listaModel);
        }
    }
}