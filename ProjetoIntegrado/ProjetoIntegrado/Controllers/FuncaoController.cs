using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class FuncaoController : Controller
    {
        // GET: Funcao
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("Membro/Funcao/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}