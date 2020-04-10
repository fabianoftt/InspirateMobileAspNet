using InspirateMobile.Infrastructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InspirateMobile.Infrastructure.Repository
{
    public class OfertaRepository
    {
        private readonly DataBaseContext context;

        public OfertaRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }

        public IList<Oferta> Listar()
        {
            return context.Oferta.ToList();
        }

        public Oferta Consultar(int id)
        {
            return context.Oferta.Find(id);
        }

        public void Inserir(Oferta oferta)
        {
            context.Oferta.Add(oferta);
            context.SaveChanges();
        }

        public void Alterar(Oferta oferta)
        {
            context.Oferta.Update(oferta);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            // Criar um tipo produto apenas com o Id
            var oferta = new Oferta()
            {
                IdOferta = id
            };

            context.Oferta.Remove(oferta);
            context.SaveChanges();
        }
    }
}