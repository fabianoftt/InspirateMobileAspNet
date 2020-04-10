using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InspirateMobile.Infrastructure.Repository;
using InspirateMobileWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace InspirateMobileWeb.Controllers
{
    public class OfertaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var listaModel = new List<Oferta>();

            OfertaRepository repo = new OfertaRepository();
            foreach (var item in repo.Listar())
            {
                listaModel.Add(new Oferta
                {
                    Id = item.IdOferta,
                    Descricao = item.Descricao,
                    Data = item.Data,
                    Situacao = item.Situacao,
                    IdUsuario = item.IdUsuario,
                    TipoOferta = item.TipoOferta,
                    DescricaoTipoOferta = StatusTipoOferta(item.TipoOferta),
                    DesricaoSituacao = StatusSituacao(item.Situacao)
                });
            }

            return View(listaModel);
        }

        private string StatusTipoOferta(int tipoOferta)
        {
            if (tipoOferta == 1)
            {
                return "Remoção";
            }
            return "Não Disponivel";
        }

        private string StatusSituacao(int sit)
        {
            if (sit == 1)
            {
                return "Disponivel";
            }
            return "Não Disponivel";
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar(Oferta oferta)
        {
            if (ModelState.IsValid)
            {
                // DAO.cadastrar();
                return RedirectToAction("Index", "Oferta");
            }
            else
            {
                return View(oferta);
            }

        }
    }
}