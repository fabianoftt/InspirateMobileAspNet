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
        [HttpGet]
        public IActionResult Index()
        {
            CategoriaItemRepository cat = new CategoriaItemRepository();

            var lista = new List<CategoriaItem>();
            foreach (var item in cat.Listar())
            {
                lista.Add(new CategoriaItem
                {
                    Id = item.IdCategoriaItem,
                    Titulo = item.Titulo
                });
            }

            return View(lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar(CategoriaItem categoriaItem)
        {
            if (ModelState.IsValid)
            {
                // DAO.cadastrar();
                return RedirectToAction("Index", "CategoriaItem");
            }
            else
            {
                return View(categoriaItem);
            }

        }
    }
}