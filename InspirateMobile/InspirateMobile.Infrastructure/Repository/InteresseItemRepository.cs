using InspirateMobile.Infrastructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            return context.InteresseItem.Find(id);
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
                Id = id
            };

            context.InteresseItem.Remove(interesseItem);
            context.SaveChanges();
        }
    }
}
