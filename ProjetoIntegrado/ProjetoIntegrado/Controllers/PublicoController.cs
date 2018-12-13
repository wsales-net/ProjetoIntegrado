﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoIntegrado.Models;

namespace ProjetoIntegrado.Controllers
{
    public class PublicoController : Controller
    {
        // GET: Publico
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("Evento/Publico/Cadastro")]
        public ActionResult Cadastro(Usuario usuario)
        {
            return View();
        }

        public JsonResult Result(string usuario)
        {
            var ajaxRetornoViewModel = false;

            if (!string.IsNullOrEmpty(usuario))
            {
                return new JsonResult
                {
                    Data = true,
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
            return new JsonResult
            {
                Data = ajaxRetornoViewModel,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}