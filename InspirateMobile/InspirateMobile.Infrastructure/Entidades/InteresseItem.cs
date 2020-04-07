using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobile.Infrastructure.Entidades
{
    [Table("INTERESSE_ITEM")]
    public class InteresseItem
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("IDINTERESSE")]
        public int IdInteresse { get; set; }

        [Column("IDOFERTAITEMS")]
        public int IdOfertaItems { get; set; }

        [Required(ErrorMessage = "Quantidade e obrigatório!")]
        [Display(Name = "Quantidade:")]
        [Column("QUANTIDADE")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Situação de negócio e obrigatório!")]
        [Display(Name = "Situação de negócio:")]
        [Column("SITUACAONEGOCIO")]
        public int SituacaoNegocio { get; set; }
    }
}
