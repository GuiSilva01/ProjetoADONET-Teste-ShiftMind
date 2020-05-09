using EntityFrameworkFolha.FoPagAux;
using EntityFrameworkFolha.FoPagAux.Entidades;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using SmartAdminMvc.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartAdminMvc.Controllers
{
    public class BaseController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationRoleManager _roleManager;

        public BaseController()
        {
        }

        public BaseController(ApplicationUserManager userManager, ApplicationSignInManager signInManager, ApplicationRoleManager roleManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            RoleManager = roleManager;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            var totalMensagensNaoLidas = ObtemTotalMensagensNaoLidas();

            ViewBag.TotalMensagensNaoLidas = (totalMensagensNaoLidas > 0) ? totalMensagensNaoLidas.ToString() : "";
        }

        private int ObtemTotalMensagensNaoLidas()
        {
            int total = 0;

            try
            {
                using (var db = new FoPagAuxDbContext())
                {
                    var excluidas = db.MensagemExcluida.Where(x => x.UsuarioID == CurrentUser.Id).ToList();
                    var msgExcIds = excluidas.Select(x => x.MensagemID);

                    total = (from msg in db.Mensagem
                             join msgDest in db.MensagemDestinatario on msg.MensagemID equals msgDest.MensagemID
                             where msgDest.DestinatarioID == CurrentUser.Id
                                && !msgExcIds.Contains(msg.MensagemID)
                                && msgDest.Lida == false
                             select msg).AsEnumerable().Count();
                }
            }
            catch
            {
                total = 0;
            }
            return total;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        public string UserName
        {
            get
            {
                return HttpContext.User.Identity.Name;
            }
        }

        public Usuario CurrentUser
        {
            get
            {
                return UserManager.FindById(User.Identity.GetUserId());
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userManager != null)
                {
                    _userManager.Dispose();
                    _userManager = null;
                }

                if (_roleManager != null)
                {
                    _roleManager.Dispose();
                    _roleManager = null;
                }

                if (_signInManager != null)
                {
                    _signInManager.Dispose();
                    _signInManager = null;
                }
            }

            base.Dispose(disposing);
        }

    }

}