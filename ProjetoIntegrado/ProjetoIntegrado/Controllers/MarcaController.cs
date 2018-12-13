using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("Produto/Marca/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}