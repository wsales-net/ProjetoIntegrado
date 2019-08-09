using ProjetoIntegrado.Dominio.DTO;

namespace ProjetoIntegrado.Dominio.Integracao.Servicos.Correios
{
    public interface ICorreiosServico
    {
        EnderecoDto ConsultarCep(string cep);
    }
}
