namespace ProjetoIntegrado.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        //public Cidade Cidade { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
    }
}