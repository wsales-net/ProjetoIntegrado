using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class LocalController : Controller
    {
        // GET: Local
        public ActionResult Index()
        {
            return View();
        }

        [Route("Produto/Local/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}