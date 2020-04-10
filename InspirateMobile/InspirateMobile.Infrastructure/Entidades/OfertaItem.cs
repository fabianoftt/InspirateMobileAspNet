using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobile.Infrastructure.Entidades
{
    [Table("OFERTA_ITEMS")]
    public class OfertaItem
    {
        [Key]
        [Column("IDOFERTAITEMS")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOfertaItems { get; set; }

        [Required(ErrorMessage = "Titulo e obrigatório!")]
        [StringLength(50, ErrorMessage = "O titulo deve ter no máximo 50 caracteres")]
        [Display(Name = "Titulo:")]
        [Column("TITULO")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Quantidade e obrigatório!")]
        [Display(Name = "Quantidade:")]
        [Column("QUANTIDADE")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Quantidade Minima e obrigatório!")]
        [Display(Name = "Quantidade Minima:")]
        [Column("QUANTIDADEMINIMA")]
        public int QuantidadeMinima { get; set; }

        [Required(ErrorMessage = "Quantidade Pacote e obrigatório!")]
        [Display(Name = "Quantidade Pacote:")]
        [Column("QUANTIDADEPACOTE")]
        public int QuantidadePacote { get; set; }

        [Required(ErrorMessage = "Unidade de medida e obrigatório!")]
        [StringLength(50, ErrorMessage = "O Unidade de medida deve ter no máximo 50 caracteres")]
        [Display(Name = "Unidade de Medida:")]
        [Column("UNIDADEMEDIDA")]
        public string UnidadeMedida { get; set; }

        [Required(ErrorMessage = "Situação e obrigatório!")]
        [Display(Name = "Situação:")]
        [Column("SITUACAO")]
        public int Situacao { get; set; }

        [Column("IDOFERTA")]
        public int IdOferta { get; set; }

        public Oferta Oferta { get; set; }

        [Column("IDCATEGORIAITEM")]
        public int IdCategoriaItem { get; set; }
        public CategoriaItem CategoriaItem { get; set; }
    }
}






