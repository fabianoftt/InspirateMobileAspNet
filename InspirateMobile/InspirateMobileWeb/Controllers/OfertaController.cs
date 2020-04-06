using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InspirateMobileWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace InspirateMobileWeb.Controllers
{
    public class OfertaController : Controller
    {
        public IActionResult Index()
        {
            var listaModel = new List<Oferta>();
            for (int i = 0; i < 100; i++)
            {
                listaModel.Add(new Oferta
                {
                    Id = i,
                   Descricao = "Titulo " + i
                });
            }

            return View(listaModel);
        }
    }
}