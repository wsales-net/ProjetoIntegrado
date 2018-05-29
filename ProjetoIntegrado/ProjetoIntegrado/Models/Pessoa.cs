using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrado.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        public int EnderecoId { get; set; }
        //public Endereco Endereco { get; set; }
        public int FuncaoId { get; set; }
        //public Funcao Funcao { get; set; }
        public int? TelefoneId { get; set; }
        //public Telefone Telefone { get; set; }

        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataRegistro { get; set; }
        public bool Ativo { get; set; }
        public string Foto { get; set; }
    }
}