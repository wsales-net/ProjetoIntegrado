using System;
using System.Web;
using System.Web.Mvc;
using ProjetoIntegrado.Dominio.Dto;

namespace ProjetoIntegrado.Authentication
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class LogInAuthorizeAttribute : AuthorizeAttribute
    {
        protected UsuarioDto UsuarioLogado;
        protected int[] FuncionalidadesPerfil;
        protected string[] IpsPermitidosAdministrador;

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            UsuarioLogado = httpContext.Session[WebKeys.UserSession] as UsuarioDto;
            FuncionalidadesPerfil = httpContext.Session["FuncionalidadesPerfil"] as int[];
            return UsuarioLogado != null && UsuarioLogado.Autenticado && !UsuarioLogado.Bloqueado;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (!AuthorizeCore(filterContext.HttpContext))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }

            if (filterContext.Result is HttpUnauthorizedResult)
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    filterContext.HttpContext.Response.StatusCode = 401;
                    filterContext.HttpContext.Response.End();
                }
            }

            base.OnAuthorization(filterContext);
        }
    }
}