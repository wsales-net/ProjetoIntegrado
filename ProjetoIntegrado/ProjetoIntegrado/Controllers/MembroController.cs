using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class MembroController : Controller
    {
        // GET: Membro
        public ActionResult Index()
        {
            return View();
        }

        [Route("Membro/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}