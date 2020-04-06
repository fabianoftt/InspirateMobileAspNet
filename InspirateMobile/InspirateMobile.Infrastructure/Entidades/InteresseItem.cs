using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobile.Infrastructure.Entidades
{
    public class InteresseItem
    {
        public int Id { get; set; }
        public int IdInteresse { get; set; }
        public int IdOfertaItems { get; set; }
        public int Quantidade { get; set; }
        public int SituacaoNegocio { get; set; }
    }
}
