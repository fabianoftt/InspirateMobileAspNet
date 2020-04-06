using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobileWeb.Models
{
    public class Mensagem
    {
        public int Id { get; set; }
        public int IdUsuarioRemetente { get; set; }
        public int IdUsuarioDestinatario { get; set; }
        public string TextoMensagem { get; set; }

        public DateTime DataLeitura { get; set; }

        public DateTime DataEnvio { get; set; }

    }
}
