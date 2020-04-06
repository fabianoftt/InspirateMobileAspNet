using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobile.Infrastructure.Entidades
{
    [Table("MENSAGEM")]
    public class Mensagem
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUsuarioRemetente { get; set; }
        public int IdUsuarioDestinatario { get; set; }
        public string TextoMensagem { get; set; }

        public DateTime DataLeitura { get; set; }

        public DateTime DataEnvio { get; set; }

    }
}
