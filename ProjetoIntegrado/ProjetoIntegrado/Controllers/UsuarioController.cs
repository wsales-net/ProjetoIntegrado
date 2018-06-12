using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [Route("Membro/Usuario/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}