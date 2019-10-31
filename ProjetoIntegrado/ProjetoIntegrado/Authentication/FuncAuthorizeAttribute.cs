using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;
using ProjetoIntegrado.Dominio.Dto;
using ProjetoIntegrado.Dominio.Enum;
using ProjetoIntegrado.Dominio.Helpers;

namespace ProjetoIntegrado.Authentication
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class FuncAuthorizeAttribute : LogInAuthorizeAttribute
    {
        public string ReturnUrl { get; set; } = "/Erro/AcessoNegado";

        public FuncionalidadeEnum Funcionalidade { get; set; }
        public FuncionalidadeEnum[] Funcionalidades { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            UsuarioLogado = httpContext.Session[WebKeys.UserSession] as UsuarioDto;

            if (UsuarioLogado == null || UsuarioLogado.Id == 0)
            {
                return false;
            }

            var temPermissao = false;

            foreach (var funcionalidadePerfil in FuncionalidadesPerfil)
            {
                temPermissao = funcionalidadePerfil == (int)Funcionalidade;
                if (temPermissao)
                {
                    break;
                }
            }

            if (!Funcionalidades.IsNullOrEmpty())
            {
                foreach (var funcionalidadePerfil in FuncionalidadesPerfil)
                {
                    temPermissao = ((IList) Funcionalidades).Contains((FuncionalidadeEnum)funcionalidadePerfil);
                    if (temPermissao)
                    {
                        break;
                    }
                }
            }

            return temPermissao;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            if (!base.AuthorizeCore(filterContext.HttpContext))
            {
                base.OnAuthorization(filterContext);
            }
            else
            {
                if (!AuthorizeCore(filterContext.HttpContext))
                {
                    if (filterContext.HttpContext.Request.IsAjaxRequest())
                    {
                        throw new HttpException(403, "Acesso Negado");
                    }
                    filterContext.Result = new RedirectResult(ReturnUrl);
                }
            }
        }
    }
}