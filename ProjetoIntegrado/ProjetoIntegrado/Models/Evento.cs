using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrado.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public int PublicoId { get; set; }
        //public Publico Publico { get; set; }
        public int EnderecoId { get; set; }
        //public Endereco Endereco { get; set; }
        public string Nome { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hora { get; set; }
        public string Descricao { get; set; }
        public int Numero { get; set; }
        public string PontoReferencia { get; set; }
    }
}