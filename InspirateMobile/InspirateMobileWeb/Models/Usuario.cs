using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobileWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int TipoOferta { get; set; }
        public string Nome { get; set; }
        public string LoginUsuario { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int Situacao { get; set; }
    }
}