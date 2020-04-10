using InspirateMobile.Infrastructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace InspirateMobile.Infrastructure.Repository
{
    public class InteresseRepository
    {
        private readonly DataBaseContext context;

        public InteresseRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }

        public IList<Interesse> Listar()
        {
            return context.Interesse.ToList();
        }

        public Interesse Consultar(int id)
        {
            return context.Interesse.Find(id);
        }

        public void Inserir(Interesse interesse)
        {
            context.Interesse.Add(interesse);
            context.SaveChanges();
        }

        public void Alterar(Interesse interesse)
        {
            context.Interesse.Update(interesse);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            // Criar um tipo produto apenas com o Id
            var interesse = new Interesse()
            {
                IdInteresse = id
            };

            context.Interesse.Remove(interesse);
            context.SaveChanges();
        }
    }
}