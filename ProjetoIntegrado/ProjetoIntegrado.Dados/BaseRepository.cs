using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado.Dados.Repositorios
{
    public class BaseRepository<TEntidade, TChave> : IBaseRepository<TEntidade, TChave> where TEntidade : class
    {
        protected DbContext _contexto;

        public BaseRepository(DbContext dbContext)
        {
            _contexto = dbContext;
        }

        public void Alterar(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public void ExcluirPorId(TChave id)
        {
            TEntidade entidade = SelecionarPorId(id);
            Excluir(entidade);
        }

        public void Inserir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Add(entidade);
            _contexto.SaveChanges();
        }

        public virtual List<TEntidade> Selecionar()
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public virtual TEntidade SelecionarPorId(TChave id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }
    }
}
