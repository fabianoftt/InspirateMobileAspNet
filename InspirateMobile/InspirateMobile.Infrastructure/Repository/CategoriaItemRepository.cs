using InspirateMobile.Infrastructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InspirateMobile.Infrastructure.Repository
{
    public class CategoriaItemRepository
    {
        private readonly DataBaseContext context;

        public CategoriaItemRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }

        public IList<CategoriaItem> Listar()
        {
            return context.CategoriaItem.ToList();
        }

        public CategoriaItem Consultar(int id)
        {
            return context.CategoriaItem.Find(id);
        }

        public void Inserir(CategoriaItem categoriaItem)
        {
            context.CategoriaItem.Add(categoriaItem);
            context.SaveChanges();
        }

        public void Alterar(CategoriaItem categoriaItem)
        {
            context.CategoriaItem.Update(categoriaItem);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            // Criar um tipo produto apenas com o Id
            var categoriaItem = new CategoriaItem()
            {
                Id = id
            };

            context.CategoriaItem.Remove(categoriaItem);
            context.SaveChanges();
        }
    }
}
