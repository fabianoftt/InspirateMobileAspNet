using InspirateMobile.Infrastructure.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InspirateMobile.Infrastructure.Repository
{
    public class UsuarioRepository
    {
        private readonly DataBaseContext context;

        public UsuarioRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }

        public IList<Usuario> Listar()
        {
            return context.Usuario.ToList();
        }

        public Usuario Consultar(int id)
        {
            return context.Usuario.Find(id);
        }

        public void Inserir(Usuario usuario)
        {
            usuario.DataCriacao = DateTime.Now;
            context.Usuario.Add(usuario);
            context.SaveChanges();
        }

        public void Alterar(Usuario usuario)
        {
            usuario.DataAtualizacao = DateTime.Now;
            context.Usuario.Update(usuario);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            // Criar um tipo produto apenas com o Id
            var usuario = new Usuario()
            {
                IdUsuario = id
            };

            context.Usuario.Remove(usuario);
            context.SaveChanges();
        }
    }
}