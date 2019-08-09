using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class FuncaoController : Controller
    {
        // GET: Funcao
        public ActionResult Index()
        {
            return View();
        }

        [Route("Membro/Funcao/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}