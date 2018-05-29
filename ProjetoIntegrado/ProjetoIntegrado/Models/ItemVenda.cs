﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrado.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        //public Venda Venda { get; set; }
        public int ProdutoId { get; set; }
        //public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}