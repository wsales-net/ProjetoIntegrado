using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("Produto/Categoria/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}