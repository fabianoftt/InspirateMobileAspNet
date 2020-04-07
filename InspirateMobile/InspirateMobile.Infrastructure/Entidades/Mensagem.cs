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

        [Column("IDUSUARIOREMETENTE")]
        public int IdUsuarioRemetente { get; set; }

        [Column("IDUSUARIODESTINATARIO")]
        public int IdUsuarioDestinatario { get; set; }

        [Required(ErrorMessage = "A Mensagem e obrigatório!")]
        [StringLength(300, ErrorMessage = "O titulo deve ter no máximo 300 caracteres")]
        [Display(Name = "Mensagem:")]
        [Column("MENSAGEM")]
        public string TextoMensagem { get; set; }

        [Required(ErrorMessage = "Data de Envio e obrigatório!")]
        [Display(Name = "Data de Envio:")]
        [Column("DATAENVIO")]
        public DateTime DataLeitura { get; set; }

        [Column("DATALEITURA")]
        public DateTime DataEnvio { get; set; }
    }
}