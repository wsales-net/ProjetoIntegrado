using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorio
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Ressuprimento()
        {
            return View();
        }

        [Authorize]
        public ActionResult Estoque()
        {
            return View();
        }
    }
}