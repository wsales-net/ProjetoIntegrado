using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class ContaController : Controller
    {
        // GET: Conta
        public ActionResult Index()
        {
            return View();
        }

        [Route("Conta/Pagamento/Cadastro")]
        public ActionResult Pagamento()
        {
            return View();
        }

        [Route("Conta/Recebimento")]
        public ActionResult Recebimento()
        {
            return View();
        }

        [Route("Conta/Pagamento/Tipo/Cadastro")]
        public ActionResult Tipo()
        {
            return View();
        }

    }
}