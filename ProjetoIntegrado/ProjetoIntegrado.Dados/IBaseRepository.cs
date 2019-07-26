using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado.Dados.Repositorios
{

    public interface IBaseRepository<TEntidade, TChave> where TEntidade : class
    {
        List<TEntidade> Selecionar();
        TEntidade SelecionarPorId(TChave id);
        void Inserir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Excluir(TEntidade entidade);
        void ExcluirPorId(TChave id);
    }
}
