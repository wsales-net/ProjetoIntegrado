namespace ProjetoIntegrado.Dominio.DTO
{
    public class EnderecoDto
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string IdUF { get; set; }
        public int? IdPais { get; set; }
    }
}
