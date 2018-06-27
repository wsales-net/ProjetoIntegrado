using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class GraficoController : Controller
    {
        // GET: Grafico
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Perdas()
        {
            return View();
        }

        public ActionResult EntradaSaida()
        {
            return View();
        }
    }
}