using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class GrupoController : Controller
    {
        // GET: Grupo
        public ActionResult Index()
        {
            return View();
        }

        [Route("Produto/Grupo/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}