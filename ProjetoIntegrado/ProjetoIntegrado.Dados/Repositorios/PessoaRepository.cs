using ProjetoIntegrado.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoIntegrado.Dados.Repositorios
{
    public class PessoaRepository : BaseRepository<Pessoa, int>
    {
        public PessoaRepository(MusicasDbContext dbContext) : base(dbContext)
        {

        }

        public override List<Pessoa> Selecionar()
        {
            return _contexto.Set<Pessoa>().Include(p => p.Musicas).ToList();
        }

        public override Pessoa SelecionarPorId(int id)
        {
            return _contexto.Set<Pessoa>().Include(p => p.Musicas).SingleOrDefault(a => a.ID == id);
        }
    }
}
