using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobileWeb.Models
{
    public class Oferta
    {
        [Required(ErrorMessage = "O ID do item é requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O IdUsuario do item é requerido")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O Tipo do item é requerido")]
        public int TipoOferta { get; set; }

        [Required(ErrorMessage = "A descrição do item é requerido")]
        [MinLength(10, ErrorMessage = "Digite uma descrição com mais de 10 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A Data do item é requerido")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "A situação do item é requerido")]
        public int Situacao { get; set; }
    }
}
