using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobileWeb.Models
{
    public class CategoriaItem
    {
        [Required(ErrorMessage = "O ID do item é requerido")]
        public int Id { get; set; }

        [Display(Name = "Item")]
        [Required(ErrorMessage = "O nome do item é requerido")]
        public string Titulo { get; set; }
    }
}
