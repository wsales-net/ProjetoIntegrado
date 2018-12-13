using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Cadastro()
        {
            return View();
        }

        [Authorize]
        public ActionResult Entrada()
        {
            return View();
        }

        [Authorize]
        public ActionResult Saida()
        {
            return View();
        }

        [Authorize]
        public ActionResult Lancamento()
        {
            return View();
        }

    }
}