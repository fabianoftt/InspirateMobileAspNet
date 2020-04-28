using System;

namespace InspirateMobileWeb.API.Model
{
    public class Interesse
    {
        public int IdInteresse { get; set; }

        public int IdUsuario { get; set; }

        public int IdOferta { get; set; }

        public DateTime Data { get; set; }

        public int SituacaoNegocio { get; set; }
    }
}
