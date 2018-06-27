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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Entrada()
        {
            return View();
        }

        public ActionResult Saida()
        {
            return View();
        }

        public ActionResult Lancamento()
        {
            return View();
        }

    }
}