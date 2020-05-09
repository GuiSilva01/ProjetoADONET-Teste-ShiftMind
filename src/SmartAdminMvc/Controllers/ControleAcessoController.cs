using EntityFrameworkFolha.FoPagAux;
using EntityFrameworkFolha.FoPagAux.Entidades;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SmartAdminMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SmartAdminMvc.Controllers
{

    public class ControleAcessoController : BaseController
    {
        private FoPagAuxDbContext db = new FoPagAuxDbContext();

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Login(LoginModel model)
        {
           /* if (!ModelState.IsValid)
            {
                return View(model);
            }
            */
            var user = await UserManager.FindByEmailAsync(model.Email);
            
            if (user != null)
            {
                if(user.Ativo)
                {

                    var result = await SignInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, shouldLockout: false);
                    switch (result)
                    {
                        case SignInStatus.Success:
                            return Redirect(GetRedirectUrl(model.ReturnUrl));
                        //case SignInStatus.LockedOut:
                        //    return View("Lockout");
                        case SignInStatus.Failure:
                        default:
                            ModelState.AddModelError("", "Usuário ou senha inválidos!");
                            return View(model);
                    }
                }
            }

            ModelState.AddModelError("", "Usuário ou senha inválidos!");
            return View();
        }

        //[CustomAuthorize(Roles = "SISTEMA,GERENCIA,OPERACIONAL")]
        [HttpGet]
        public ActionResult Usuarios()
        {
            var ctx = Request.GetOwinContext();
            var usuarios = new List<UsuarioModel>();
            var usuarioLogado = User.Identity.GetUserId();

            var users = UserManager.Users.Where(x => x.Id == usuarioLogado).ToList();

            foreach (var user in users)
            {
                var roleName = string.Empty;

                if (user.Roles != null && user.Roles.Count > 0)
                {
                    var roleId = user.Roles.FirstOrDefault().RoleId;

                    var roles = RoleManager.Roles.ToList();
                    roleName = RoleManager.FindById(roleId).Name;
                }

                usuarios.Add(new UsuarioModel {
                    Id = user.Id,
                    Nome = user.UserName,
                    Email = user.Email,
                    Grupo = roleName,
                    Ativo = user.Ativo
                });
            }

            return View(usuarios);
        }

        [CustomAuthorize(Roles = "SISTEMA,GERENCIA")]
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Grupos = GetListaGrupos("");

            return View(new UsuarioModel());
        }

        [CustomAuthorize(Roles = "SISTEMA,GERENCIA")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new Usuario
                {
                    Nome = model.Nome,
                    Email = model.Email,
                    UserName = model.Nome,
                    Ativo = model.Ativo,
                    LockoutEnabled = !model.Ativo
                };

                var result = await UserManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var roleresult = UserManager.AddToRole(user.Id, model.Grupo);

                    //Envia mensagem de boas vindas para este novo usuário
                    var msgExemplo = db.Mensagem.Find(1);
                    var novaMensagem = new Mensagem()
                    {
                        DataCriacao = DateTime.Now,
                        RemetenteID = "1",
                        Assunto = msgExemplo.Assunto,
                        Conteudo = msgExemplo.Conteudo,
                    };

                    db.Mensagem.Add(novaMensagem);
                    db.SaveChanges();

                    db.MensagemDestinatario.Add(new MensagemDestinatario
                    {
                        MensagemID = novaMensagem.MensagemID,
                        DestinatarioID = user.Id,
                        Lida = false
                    });

                    db.SaveChanges();

                    db.MensagemFlag.Add(new MensagemFlag { UsuarioID = user.Id, MensagemID = novaMensagem.MensagemID, FlagID = 2 });

                    db.SaveChanges();

                    return RedirectToAction("Usuarios");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error);
                }
            }

            var errors = ModelState.Select(x => x.Value.Errors)
                           .Where(y => y.Count > 0)
                           .ToList();

            foreach(var error in errors)
            {
                ModelState.AddModelError("", error.ToString());
            }
            
            ViewBag.Grupos = GetListaGrupos(model.Grupo);

            return View(model);
        }

        [CustomAuthorize(Roles = "SISTEMA")]
        [HttpGet]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var model = GetUsuarioModel(id);

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            var userDb = UserManager.FindById(id);
            userDb.Ativo = false;
            var result = await UserManager.UpdateAsync(userDb);

            //var result = await UserManager.DeleteAsync(userDb);

            if (result.Succeeded)
            {
                return RedirectToAction("Usuarios");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }

            var model = GetUsuarioModel(id);

            ViewBag.Grupos = GetListaGrupos(model.Grupo);

            return View(model);
        }

        [CustomAuthorize(Roles = "SISTEMA")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var model = GetUsuarioModel(id);

            ViewBag.Grupos = GetListaGrupos(model.Grupo);

            return View(model);
        }

        //CustomAuthorize(Roles = "SISTEMA")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var model = GetUsuarioModel(id);

            ViewBag.Grupos = GetListaGrupos(model.Grupo);

            return View(model);
        }

        [CustomAuthorize(Roles = "SISTEMA")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(UsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                var userDb = UserManager.FindById(model.Id);

                userDb.Nome = model.Nome;
                userDb.Email = model.Email;
                userDb.Ativo = model.Ativo;
                userDb.UserName = model.Nome;
                userDb.LockoutEnabled = !model.Ativo;

                var result = await UserManager.UpdateAsync(userDb);

                if (result.Succeeded)
                {
                    var roleName = string.Empty;

                    if (userDb.Roles != null && userDb.Roles.Count > 0)
                    {
                        var roleId = userDb.Roles.FirstOrDefault().RoleId;
                        var roles = RoleManager.Roles.ToList();
                        roleName = roles.FirstOrDefault(x => x.Id == roleId).Name;
                    }

                    if(roleName != model.Grupo)
                    {
                        //Remove usuário da Role
                        UserManager.RemoveFromRole(userDb.Id, roleName);

                        //Adiciona usuário em uma nova Role
                        UserManager.AddToRole(userDb.Id, model.Grupo);
                    }

                    return RedirectToAction("Usuarios");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error);
                }
            }

            var errors = ModelState.Select(x => x.Value.Errors)
                           .Where(y => y.Count > 0)
                           .ToList();

            foreach (var error in errors)
            {
                ModelState.AddModelError("", error.ToString());
            }

            ViewBag.Grupos = GetListaGrupos(model.Grupo);

            return View(model);
        }

        //[CustomAuthorize(Roles = "SISTEMA")]
        [HttpGet]
        public ActionResult Password(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var model = GetUsuarioModel(id);
            var modelPassword = new UsuarioPasswordModel
            {
                Id = model.Id,
                Nome = model.Nome
            };

            return View(modelPassword);
        }

        //[CustomAuthorize(Roles = "SISTEMA")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Password(UsuarioPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var userDb = UserManager.FindById(model.Id);

                if (!string.IsNullOrEmpty(model.Password))
                {
                    var token =  await UserManager.GeneratePasswordResetTokenAsync(userDb.Id);

                    var result = await UserManager.ResetPasswordAsync(userDb.Id, token, model.Password);

                    if(result.Succeeded)
                    {
                        return RedirectToAction("Usuarios");
                    }
                    
                }
            }

            var errors = ModelState.Select(x => x.Value.Errors)
                            .Where(y => y.Count > 0)
                            .ToList();

            foreach (var error in errors)
            {
                ModelState.AddModelError("", error.ToString());
            }

            return View(model);
        }

        private dynamic GetListaGrupos(string nomeGrupoSelecionar)
        {
            var ctx = Request.GetOwinContext();
            var roles = RoleManager.Roles.ToList();

            var grupos = new List<GrupoUsuarioModel>();
            foreach (var role in roles)
            {
                grupos.Add(new GrupoUsuarioModel
                {
                    Id = role.Id,
                    Name = role.Name,
                    Selected = (nomeGrupoSelecionar.Equals(role.Name))
                });
            }

            return grupos;
        }

        private UsuarioModel GetUsuarioModel(string id)
        {
            var userDb = UserManager.FindById(id);

            if (userDb == null)
            {
                return null;
            }

            var roleName = string.Empty;

            if (userDb.Roles != null && userDb.Roles.Count > 0)
            {

                var roleId = userDb.Roles.FirstOrDefault().RoleId;
                var roles = RoleManager.Roles.ToList();
                roleName = roles.FirstOrDefault(x => x.Id == roleId).Name;
            }

            var usuario = new UsuarioModel()
            {
                Id = userDb.Id,
                Nome = userDb.Nome,
                Email = userDb.Email,
                Grupo = roleName,
                Ativo = userDb.Ativo
            };

            return usuario;
        }

        private IAuthenticationManager GetAuthenticationManager()
        {
            var ctx = Request.GetOwinContext();
            return ctx.Authentication;
        }

        [AllowAnonymous]
        public ActionResult Logoff()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut();
            return RedirectToAction("index", "home");
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if (!string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("index", "home");
            }

            return returnUrl;
        }
    }
}