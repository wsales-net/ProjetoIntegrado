using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class CaixaController : Controller
    {
        // GET: Conta
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("Caixa/Pagamento/Cadastro")]
        public ActionResult Pagamento()
        {
            return View();
        }

        [Authorize]
        public ActionResult Recebimento()
        {
            return View();
        }

        [Authorize]
        [Route("Caixa/Pagamento/Tipo/Cadastro")]
        public ActionResult Tipo()
        {
            return View();
        }

    }
}