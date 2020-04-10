using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobile.Infrastructure.Entidades
{
    [Table("OFERTA")]
    public class Oferta
    {
        [Key]
        [Column("IDOFERTA")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOferta { get; set; }

        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }

        [Column("TIPOOFERTA")]
        public int TipoOferta { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Data e obrigatório!")]
        [Display(Name = "Data:")]
        [Column("DATA")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Situação e obrigatório!")]
        [Display(Name = "Situação:")]
        [Column("SITUACAO")]
        public int Situacao { get; set; }
    }
}


