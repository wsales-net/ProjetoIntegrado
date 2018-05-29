using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrado.Models
{
    public class ContaReceber
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int FormaPagamentoId { get; set; }
        //public Venda Venda { get; set; }
        //public FormaPagamento FormaPagamento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Observacao { get; set; }
    }
}