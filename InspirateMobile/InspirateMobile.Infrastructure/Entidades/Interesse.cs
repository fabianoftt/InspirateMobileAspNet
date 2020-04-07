using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobile.Infrastructure.Entidades
{
    [Table("INTERESSE")]
    public class Interesse
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }

        [Column("IDOFERTA")]
        public int IdOferta { get; set; }

        [Required(ErrorMessage = "Data e obrigatório!")]
        [Display(Name = "Data:")]
        [Column("DATA")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Situação Negócio e obrigatório!")]
        [Display(Name = "Situação Negócio:")]
        [Column("SITUACAONEGOCIO")]
        public int SituacaoNegocio { get; set; }
    }
}
