using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrado.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        //public Pessoa Pessoa { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorPago { get; set; }
    }
}