﻿using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            return View();
        }

        [Route("Produto/Marca/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}