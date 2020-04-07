using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InspirateMobile.Infrastructure.Repository;
using InspirateMobileWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace InspirateMobileWeb.Controllers
{
    public class CategoriaItemController : Controller
    {     
        public IActionResult Index()
        {
            CategoriaItemRepository ctc = new CategoriaItemRepository();
            ctc.Inserir(new InspirateMobile.Infrastructure.Entidades.CategoriaItem 
            {
            Id = 0,
            Titulo = "SOFA"
            
            });
            var lista = new List<CategoriaItem>();
            foreach (var item in ctc.Listar())
            {
                lista.Add(new CategoriaItem
                {
                    Id = item.Id,
                    Titulo = item.Titulo
                });
            }

            return View(lista);
        }
    }
}