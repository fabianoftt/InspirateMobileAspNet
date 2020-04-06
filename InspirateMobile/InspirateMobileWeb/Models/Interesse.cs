using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobileWeb.Models
{
    public class Interesse
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdOferta { get; set; }
        public DateTime Data { get; set; }
        public int SituacaoNegocio { get; set; }
    }
}