using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrado.Models
{
    public class ContaPagar
    {
        public int Id { get; set; }
        public int TipoContaId { get; set; }
        //public TipoContaPagar TipoContaPagar { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}