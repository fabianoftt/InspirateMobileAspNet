﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobileWeb.API.Model
{
    public class Oferta
    {
        public int IdOferta { get; set; }

        public int IdUsuario { get; set; }

        public int TipoOferta { get; set; }

        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public int Situacao { get; set; }
    }
}
