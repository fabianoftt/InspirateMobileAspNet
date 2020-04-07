using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobileWeb.Models
{
    public class CategoriaItem
    {
        [Required(ErrorMessage = "O ID da categoria é requerido")]
        public int Id { get; set; }

        [Display(Name = "Nome da categoria")]
        [Required(ErrorMessage = "O nome da categoria é requerido")]
        public string Titulo { get; set; }
    }
}
