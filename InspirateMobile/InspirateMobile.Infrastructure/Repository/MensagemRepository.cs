using InspirateMobile.Infrastructure.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InspirateMobile.Infrastructure.Repository
{
   public class MensagemRepository
    {
        private readonly DataBaseContext context;

        public MensagemRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }

        public IList<Mensagem> Listar()
        {
            return context
                .Mensagem
                //.Include(t => t.UsuarioDestinatario)
                //.Include(c => c.UsuarioRemetente)
                .ToList();
        }

        public Mensagem Consultar(int id)
        {
            return context.Mensagem
               //.Include(t => t.UsuarioDestinatario)
               // .Include(c => c.UsuarioRemetente)
                .FirstOrDefault(c => c.IdMensagem == id);
        }

        public void Inserir(Mensagem mensagem)
        {
            context.Mensagem.Add(mensagem);
            context.SaveChanges();
        }

        public void Alterar(Mensagem mensagem)
        {
            context.Mensagem.Update(mensagem);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            // Criar um tipo produto apenas com o Id
            var mensagem = new Mensagem()
            {
                IdMensagem = id
            };

            context.Mensagem.Remove(mensagem);
            context.SaveChanges();
        }
    }
}
