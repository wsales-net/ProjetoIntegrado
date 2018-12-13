using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoIntegrado.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int PerfilId { get; set; }
        //public Pessoa Pessoa { get; set; }
        //public Perfil Perfil { get; set; }
        [Required(ErrorMessage = "Informe o usuário")]
        [Display(Name = "Usuário:")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        [Display(Name = "Lembrar-Me:")]
        public bool LembrarMe { get; set; }
    }
}