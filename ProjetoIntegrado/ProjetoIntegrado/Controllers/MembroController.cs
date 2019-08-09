using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class MembroController : Controller
    {
        // GET: Membro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }
    }
}