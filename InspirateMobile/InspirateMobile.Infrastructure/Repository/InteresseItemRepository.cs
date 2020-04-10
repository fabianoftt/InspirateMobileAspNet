using InspirateMobile.Infrastructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace InspirateMobile.Infrastructure.Repository
{
    public class InteresseItemRepository
    {
        private readonly DataBaseContext context;

        public InteresseItemRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }

        public IList<InteresseItem> Listar()
        {
            return context.InteresseItem.ToList();
        }

        public InteresseItem Consultar(int id)
        {
            return context.InteresseItem
                .Include(t => t.Interesse)
                .Include(c => c.OfertaItem)
                .FirstOrDefault(c => c.IdInteresseItem == id);
        }

        public void Inserir(InteresseItem interesseItem)
        {
            context.InteresseItem.Add(interesseItem);
            context.SaveChanges();
        }

        public void Alterar(InteresseItem interesseItem)
        {
            context.InteresseItem.Update(interesseItem);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            // Criar um tipo produto apenas com o Id
            var interesseItem = new InteresseItem()
            {
                IdInteresseItem = id
            };

            context.InteresseItem.Remove(interesseItem);
            context.SaveChanges();
        }
    }
}
