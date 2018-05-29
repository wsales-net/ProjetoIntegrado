namespace ProjetoIntegrado.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public int EstadoId { get; set; }
        //public Estado Estado { get; set; }
        public string Numero { get; set; }
        public string Servico { get; set; }
    }
}