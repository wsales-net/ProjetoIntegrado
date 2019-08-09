using System.ServiceModel;
using ProjetoIntegrado.Dominio.DTO;
using ProjetoIntegrado.Dominio.Integracao.Servicos.Correios;
using ProjetoIntregado.Integracao.CorreiosServico;

namespace ProjetoIntregado.Integracao.Servicos.Correios
{
    public class CorreiosServico : ICorreiosServico
    {
        public EnderecoDto ConsultarCep(string cep)
        {
            var binding = new BasicHttpBinding();
            binding.Name = "AtendeClientePort";
            binding.Security.Mode = BasicHttpSecurityMode.Transport;

            var endPoint = new EndpointAddress("https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl");

            var correioServico = new AtendeClienteClient(binding, endPoint);

            var response = correioServico.consultaCEP(cep);

            return new EnderecoDto
            {
                Cep = cep,
                Bairro = response.bairro,
                Cidade = response.cidade,
                Complemento = response.complemento
            };
        }
    }
}
