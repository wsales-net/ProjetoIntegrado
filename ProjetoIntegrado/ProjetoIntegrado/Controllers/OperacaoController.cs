﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrado.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inventario()
        {
            return View();
        }
    }
}