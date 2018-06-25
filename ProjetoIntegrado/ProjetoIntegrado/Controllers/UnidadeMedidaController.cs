using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class UnidadeMedidaController : Controller
    {
        // GET: UnidadeMedida
        public ActionResult Index()
        {
            return View();
        }

        [Route("Produto/Unidade/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}