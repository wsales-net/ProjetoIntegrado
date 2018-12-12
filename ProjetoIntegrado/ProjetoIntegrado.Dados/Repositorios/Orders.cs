using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado.Dados.Repositorios
{
    public struct Order
    {
        public string Column { get; set; }
        public OrderDirection Direction { get; set; }
    }
}
