using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrado.Models
{
    public class Oferta
    {
        public int Id { get; set; }
        public int? PessoaId { get; set; }
        //public Pessoa Pessoa { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Observacao { get; set; }
    }
}