using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobileWeb.Models
{
    public class OfertaItem
    {
        public int Id { get; set; }
        public int IdOferta { get; set; }
        public int IdCategoriaItem { get; set; }
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeMinima { get; set; }
        public int QuantidadePacote { get; set; }
        public string UnidadeMedida { get; set; }
        public int Situacao { get; set; }
    }
}
