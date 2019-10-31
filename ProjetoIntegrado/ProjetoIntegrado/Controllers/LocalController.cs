using System.Web.Mvc;
using ProjetoIntegrado.Authentication;
using ProjetoIntegrado.Dominio.Enum;

namespace ProjetoIntegrado.Controllers
{
    public class LocalController : Controller
    {
        // GET: Local
        public ActionResult Index()
        {
            return View();
        }

        [FuncAuthorize(Funcionalidade = FuncionalidadeEnum.AdicionarRemoverFavoritosAplicacao)]
        [Route("Produto/Local/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}