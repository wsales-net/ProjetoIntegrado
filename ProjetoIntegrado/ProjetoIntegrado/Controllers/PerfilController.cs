using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult Index()
        {
            return View();
        }

        [Route("Membro/Perfil/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}