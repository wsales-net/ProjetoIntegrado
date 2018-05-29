using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrado.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public int EstadoId { get; set; }
        //public Estado Estado { get; set; }
        public string Descricao { get; set; }
    }
}