using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class PublicoController : Controller
    {
        // GET: Publico
        public ActionResult Index()
        {
            return View();
        }

        [Route("Evento/Publico/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}