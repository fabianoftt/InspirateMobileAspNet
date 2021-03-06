﻿using InspirateMobile.Infrastructure.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InspirateMobile.Infrastructure.Repository
{
    public class OfertaItemRepository
    {
        private readonly DataBaseContext context;

        public OfertaItemRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }

        public IList<OfertaItem> Listar()
        {
            return context
                .OfertaItem
                .Include(t => t.CategoriaItem)
                .Include(c => c.Oferta)
                .ToList();
        }

        public OfertaItem Consultar(int id)
        {
            return context.OfertaItem
                .Include(t => t.Oferta)
                .Include(c => c.CategoriaItem)
                .FirstOrDefault(c => c.IdOfertaItems == id);
        }

        public void Inserir(OfertaItem ofertaItem)
        {
            context.OfertaItem.Add(ofertaItem);
            context.SaveChanges();
        }

        public void Alterar(OfertaItem ofertaItem)
        {
            context.OfertaItem.Update(ofertaItem);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            // Criar um tipo produto apenas com o Id
            var ofertaItem = new OfertaItem()
            {
                IdOfertaItems = id
            };

            context.OfertaItem.Remove(ofertaItem);
            context.SaveChanges();
        }
    }
}