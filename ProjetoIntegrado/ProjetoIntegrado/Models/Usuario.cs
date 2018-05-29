using System;
using System.Collections.Generic;
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
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}