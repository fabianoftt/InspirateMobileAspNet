using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InspirateMobile.Infrastructure.Entidades
{
    [Table("USUARIO")]
    public class Usuario
    {
        [Key]
        [Column("IDUSUARIO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Nome e obrigatório!")]
        [StringLength(150, ErrorMessage = "O nome deve ter no máximo 150 caracteres")]
        [Display(Name = "Nome:")]
        [Column("NOME")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Login do usuário e obrigatório!")]
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        [Display(Name = "Usuario:")]
        [Column("USUARIO")]
        public string LoginUsuario { get; set; }

        [Required(ErrorMessage = "A senha do usuário e obrigatório!")]
        [StringLength(50, ErrorMessage = "A senha deve ter no máximo 50 caracteres")]
        [Display(Name = "Senha:")]
        [Column("SENHA")]
        public string Senha { get; set; }

        [Column("TELEFONE")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Email e obrigatório!")]
        [Display(Name = "Email:")]
        [Column("EMAIL")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A situação do usuário e obrigatório!")]
        [Display(Name = "Situação:")]
        [Column("SITUACAO")]
        public int Situacao { get; set; }
    }
}





