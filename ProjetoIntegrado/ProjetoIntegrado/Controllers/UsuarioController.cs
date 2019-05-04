using ProjetoIntegrado.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjetoIntegrado.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize] //Acesso permitido somente com login
        [Route("Membro/Usuario/Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }

        [AllowAnonymous] //Livre. Ativado em web.config authentication e authorization
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Usuario usuario)
        {
            //Valida se a entrada do usuario esta correto
            if (!ModelState.IsValid) //Se os dados que os usuarios digitou ainda são invalidos, exibe novamente a pagina de login
            {
                return View(usuario);
            }

            var achou = true;// UsuarioDAO.CheckUser(usuario.Login, usuario.Senha);

            if (achou)
            {
                FormsAuthentication.SetAuthCookie(usuario.Login, usuario.LembrarMe);
                //if (Url.IsLocalUrl(returnUrl))
                //{
                //    return Redirect(returnUrl);
                //}
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ModelState.AddModelError("", "Login Inválido.");
                return View(usuario);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Usuario");
        }
    }
}