using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("Membro/Perfil/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}