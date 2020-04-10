using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InspirateMobile.Infrastructure.Entidades
{
    [Table("CATEGORIA_ITEM")]
    public class CategoriaItem
    {
        [Key]
        [Column("IDCATEGORIAITEM")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCategoriaItem { get; set; }

        [Required(ErrorMessage = "Titulo e obrigatório!")]
        [StringLength(50, ErrorMessage = "O titulo deve ter no máximo 50 caracteres")]
        [Display(Name = "Titulo:")]
        [Column("TITULO")]
        public string Titulo { get; set; }
    }
}
