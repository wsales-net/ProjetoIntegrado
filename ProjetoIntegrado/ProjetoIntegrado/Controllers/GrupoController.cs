using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class GrupoController : Controller
    {
        // GET: Grupo
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("Produto/Grupo/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}