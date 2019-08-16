using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoIntegrado.Dominio.Helpers;

namespace ProjetoIntegrado.Dominio.Dto
{
    public class UsuarioDto
    {
        public bool Mobile { get; set; }
        public int Id { get; set; }

        // Dados do Usuário
        public string Nome { get; set; }
        public string PrimeiroNome => Nome.IsNullOrEmptyTrim() ? "" : Nome.Split(' ').First().Capitalize();
        public string CodigoInternoUsuario { get; set; }
        public string Email { get; set; }
        public bool NotificaEmail { get; set; }
        public int PerfilId { get; set; }
        public string NomePerfil { get; set; }
        public string NomeNivel { get; set; }
        public string Cpf { get; set; }
        public DateTime DataHoraLogin { get; set; }
        public int QuantidadeDeLoginsEfetuados { get; set; }
        public string Token { get; set; }
        public bool Bloqueado { get; set; }
        public string DescricaoBloqueado { get; set; }
        public int CodigoFuncionalidades { get; set; }
        public int NivelId { get; set; }
        public int PessoaId { get; set; }
        public int PessoaFisicaId { get; set; }
        public int PessoaJuridicaId { get; set; }
        public string FichaCadastralId { get; set; }
        public int SituacaoFichaId { get; set; }
        public int EtapaCadastro { get; set; }
        public bool OperaInvestimentos { get; set; }
        public int AutenticacaoId { get; set; }
        public bool Autenticado { get; set; }
        public bool FichaCadastralProximaDeExpirarOuExpirou { get; set; }
        public bool AssinarFicha { get; set; }
        public int TipoAssinaturaFichaCadastralId { get; set; }

        // Dados do Gerente de Captação
        public int OperadorInvestimentoId { get; set; }
        public int OperadorCambioId { get; set; }
        public int MesaOperacaoId { get; set; }
        public bool OperadorAtivo { get; set; }
        public string CodigoInternoOperador { get; set; }

        // Dados da conta selecionada
        public int ContaSelecionadaId { get; set; }
        public string ContaSelecionada { get; set; }
        public IList<int> AreasAtendimento { get; set; }

        // Permissões do menu lateral
        public bool VisualizaNovosInvestimento { get; set; }
        public bool VisualizaSaldoCambio { get; set; }
        public bool VisualizaSaldoMovimentacaoInvestimento { get; set; }
        public bool VisualizarDocumentosInvestidor { get; set; }
        public bool VisualizaDocumentosAcessorios { get; set; }
        public bool VisualizaPerfilInvestidor { get; set; }
        public bool VisualizaDadosCadastrais { get; set; }
        public IList<MenuItemDto> MenuNavegacao { get; set; }

        // Dados do Operador de Carteira de Captação
        public int CarteiraId { get; set; }
        public string CarteiraNome { get; set; }
    }
}
