using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }

        [Route("Produto/Categoria/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}