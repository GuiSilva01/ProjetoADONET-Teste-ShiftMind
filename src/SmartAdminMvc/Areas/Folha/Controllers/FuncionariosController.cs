using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkFolha.FoPagAux;
using EntityFrameworkFolha.FoPagAux.Entidades;
using System.Web.Routing;

namespace SmartAdminMvc.Areas.Folha.Controllers
{
    public class FuncionariosController : BaseAreaController
    {


        public FuncionariosController()
        {

        }

        protected override void Initialize(RequestContext requestContext)
        {
            // the controller's UrlHelper is still null
            base.Initialize(requestContext);

            // the controller's UrlHelper is now ready to use!
            //var url = Url.RouteUrl()
            object funcionarioID = "";
            this.ControllerContext.RouteData.Values.TryGetValue("id", out funcionarioID);
            if (funcionarioID != null)
            {
                String pathDocumentos = Server.MapPath("~/Documentos/" + funcionarioID.ToString());
                bool exists = System.IO.Directory.Exists(pathDocumentos);
                if (!exists)
                    System.IO.Directory.CreateDirectory(pathDocumentos);
            }

        }

        private void CreateViewBags(Funcionario funcionario)
        {

            ViewBag.qtdFaltas = db.Falta.Where(x => x.FuncionarioID == funcionario.FuncionarioID).ToList();

            ViewBag.qtdFts = db.Falta.Where(x => x.FuncionarioSubstitutoID == funcionario.FuncionarioID).ToList();

            ViewBag.qtdAtrasos = db.Atraso.Where(x => x.FuncionarioID == funcionario.FuncionarioID).ToList();

            ViewBag.qtdBH = 0; //await db..Where(x => x.FuncionarioSubstitutoID == funcionario.FuncionarioID).ToListAsync();

            ViewBag.qtdHE = 0; //await db..Where(x => x.FuncionarioSubstitutoID == funcionario.FuncionarioID).ToListAsync();
        }

        // GET: Folha/Funcionarios
        public async Task<ActionResult> Index()
        {
            foreach (var f in db.Funcionario.ToList())
            {
                String pathDocumentos = Server.MapPath("~/Documentos/" + f.FuncionarioID);
                String pathDocumentosNovo = Server.MapPath("~/Documentos/" + f.FuncionarioID + "_" + f.Nome.Replace(" ", "_"));

                bool exists = System.IO.Directory.Exists(pathDocumentos);
                if (!exists)
                    System.IO.Directory.CreateDirectory(pathDocumentos);

                bool existsNovo = System.IO.Directory.Exists(pathDocumentosNovo);
                if (!existsNovo)
                    System.IO.Directory.CreateDirectory(pathDocumentosNovo);
            }

            var funcionario = db.Funcionario.Where(x => x.Admissao != null && x.Demissao == null).Include(f => f.Empresa).Include(f => f.PostoTrabalho);

            return View(await funcionario.ToListAsync());
        }

        public async Task<ActionResult> IndexPendentes()
        {
            var funcionario = db.Funcionario.Where(x => x.Admissao == null).Include(f => f.Empresa).Include(f => f.PostoTrabalho);
            return View("Pendentes", await funcionario.ToListAsync());
        }

        public async Task<ActionResult> IndexDemitidos()
        {
            var funcionario = db.Funcionario.Where(x => x.Demissao != null).Include(f => f.Empresa).Include(f => f.PostoTrabalho);
            return View("Demitidos", await funcionario.ToListAsync());
        }

        #region Visualizar
        // GET: Folha/Funcionarios/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = await db.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }

            CreateViewBags(funcionario);

            String pathDocumentos = Server.MapPath("~/Documentos/" + id);
            ViewBag.Images = System.IO.Directory.EnumerateFiles(pathDocumentos).Select(fn => "~/Documentos/" + id + "/" + System.IO.Path.GetFileName(fn));

            return View(funcionario);
        }

        public async Task<ActionResult> Visualizar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = await db.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cargo = new SelectList(db.Cargo.ToList(), "CargoID", "Nome", funcionario.CargoID);
            ViewBag.Empresa = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.EmpresaID);
            ViewBag.Empresa2 = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.Empresa2ID);
            ViewBag.Empresa3 = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.Empresa3ID);
            ViewBag.PostoTrabalho = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalhoID);
            ViewBag.PostoTrabalho2 = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalho2ID);
            ViewBag.PostoTrabalho3 = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalho3ID);
            ViewBag.Salario = new SelectList(db.Salario.ToList(), "SalarioID", "Nome", funcionario.SalarioID);
            ViewBag.Lider = new SelectList(db.Funcionario.ToList(), "FuncionarioID", "Nome", funcionario.LiderID);
            ViewBag.SexoList = new SelectList(SexoList, "Key", "Value", funcionario.Sexo);
            ViewBag.UfList = new SelectList(UfList, "Key", "Value", funcionario.EstadoExpedidorRG);
            ViewBag.EstadoCivilList = new SelectList(EstadoCivilList, "Key", "Value", funcionario.EstadoCivil);

            CreateViewBags(funcionario);

            String pathDocumentos = Server.MapPath("~/Documentos/" + id);
            ViewBag.Images = System.IO.Directory.EnumerateFiles(pathDocumentos).Select(fn => "~/Documentos/" + id + "/" + System.IO.Path.GetFileName(fn));
            return View("Visualizar", funcionario);
        }

        public async Task<ActionResult> DetailsPartial(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = await db.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }

            CreateViewBags(funcionario);

            String pathDocumentos = Server.MapPath("~/Documentos/" + id);
            ViewBag.Images = System.IO.Directory.EnumerateFiles(pathDocumentos).Select(fn => "~/Documentos/" + id + "/" + System.IO.Path.GetFileName(fn));


            return PartialView("_DetalhesFuncionario", funcionario);
        }

        #endregion

        // GET: Folha/Funcionarios/Create
        public ActionResult Create()
        {
            ViewBag.Cargo = new SelectList(db.Cargo.ToList(), "CargoID", "Nome");
            ViewBag.Empresa = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome");
            ViewBag.Empresa2 = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome");
            ViewBag.Empresa3 = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome");
            ViewBag.PostoTrabalho = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome");
            ViewBag.PostoTrabalho2 = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome");
            ViewBag.PostoTrabalho3 = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome");
            ViewBag.Salario = new SelectList(db.Salario.ToList(), "SalarioID", "Nome");
            ViewBag.Lider = new SelectList(db.Funcionario.ToList(), "FuncionarioID", "Nome");
            ViewBag.SexoList = new SelectList(SexoList, "Key", "Value");
            ViewBag.UfList = new SelectList(UfList, "Key", "Value");
            ViewBag.EstadoCivilList = new SelectList(EstadoCivilList, "Key", "Value");

            return View();
        }

        // POST: Folha/Funcionarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FuncionarioID,Nome,Matricula,CPF,RG,CTPS,TelefoneResidencial,TelefoneCelular,Email,RedeSocial,NomeMae,NomePai,EstadoCivil,Naturalidade,DataNascimento,DataExameAdimissional,EscalaHorario,DataEmissaoRG,OrgaoExpedidorRG,EstadoExpedidorRG,DataExpedicaoCTPS,DataExameAdmissional,Inicio,Admissao,Demissao,Foto,CargoID,LiderID,SalarioID,EmpresaID,Empresa2ID,Empresa3ID,PostoTrabalhoID,PostoTrabalho2ID,PostoTrabalho3ID,NomeConjuge,Sexo,PIS,TituloEleitor,Lideranca,UsuarioAlteracao,DataAlteracao,Observacao,Ativo,Versao")] Funcionario funcionario)
        {
            funcionario.Ativo = true;
            funcionario.DataCriacao = DateTime.Now;
            funcionario.UsuarioCriacao = User.Identity.Name;

            if (ModelState.IsValid)
            {
                db.Funcionario.Add(funcionario);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Cargo = new SelectList(db.Cargo.ToList(), "CargoID", "Nome", funcionario.CargoID);
            ViewBag.Empresa = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.EmpresaID);
            ViewBag.Empresa2 = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.Empresa2ID);
            ViewBag.Empresa3 = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.Empresa3ID);
            ViewBag.PostoTrabalho = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalhoID);
            ViewBag.PostoTrabalho2 = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalho2ID);
            ViewBag.PostoTrabalho3 = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalho3ID);
            ViewBag.Salario = new SelectList(db.Salario.ToList(), "SalarioID", "Nome", funcionario.SalarioID);
            ViewBag.Lider = new SelectList(db.Funcionario.ToList(), "FuncionarioID", "Nome", funcionario.LiderID);
            ViewBag.SexoList = new SelectList(SexoList, "Key", "Value", funcionario.Sexo);
            ViewBag.UfList = new SelectList(UfList, "Key", "Value", funcionario.EstadoExpedidorRG);
            ViewBag.EstadoCivilList = new SelectList(EstadoCivilList, "Key", "Value", funcionario.EstadoCivil);
            return View(funcionario);
        }

        // GET: Folha/Funcionarios/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = await db.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cargo = new SelectList(db.Cargo.ToList(), "CargoID", "Nome", funcionario.CargoID);
            ViewBag.Escala = new SelectList(db.Escala.ToList(), "EscalaID", "Nome", funcionario.EscalaID);
            ViewBag.Turno = new SelectList(db.Turno.ToList(), "TurnoID", "Nome", funcionario.TurnoID);
            ViewBag.Empresa = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.EmpresaID);
            ViewBag.Empresa2 = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.Empresa2ID);
            ViewBag.Empresa3 = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.Empresa3ID);
            ViewBag.PostoTrabalho = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalhoID);
            ViewBag.PostoTrabalho2 = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalho2ID);
            ViewBag.PostoTrabalho3 = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalho3ID);
            ViewBag.Salario = new SelectList(db.Salario.ToList(), "SalarioID", "Nome", funcionario.SalarioID);
            ViewBag.Lider = new SelectList(db.Funcionario.ToList(), "FuncionarioID", "Nome", funcionario.LiderID);
            ViewBag.SexoList = new SelectList(SexoList, "Key", "Value", funcionario.Sexo);
            ViewBag.UfList = new SelectList(UfList, "Key", "Value", funcionario.EstadoExpedidorRG);
            ViewBag.EstadoCivilList = new SelectList(EstadoCivilList, "Key", "Value", funcionario.EstadoCivil);
            String pathDocumentos = Server.MapPath("~/Documentos/" + id);
            ViewBag.Images = System.IO.Directory.EnumerateFiles(pathDocumentos).ToList().Select(fn => "~/Documentos/" + id + "/" + System.IO.Path.GetFileName(fn));
            return View(funcionario);
        }

        // POST: Folha/Funcionarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FuncionarioID,Nome,Matricula,CPF,RG,CTPS,TelefoneResidencial,TelefoneCelular,Email,RedeSocial,NomeMae,NomePai,EstadoCivil,Naturalidade,DataNascimento,DataExameAdimissional,EscalaHorario,DataEmissaoRG,OrgaoExpedidorRG,EstadoExpedidorRG,DataExpedicaoCTPS,DataExameAdmissional,Inicio,Admissao,Demissao,Foto,CargoID,LiderID,SalarioID,EmpresaID,Empresa2ID,Empresa3ID,PostoTrabalhoID,PostoTrabalho2ID,PostoTrabalho3ID,NomeConjuge,Sexo,PIS,TituloEleitor,Lideranca,UsuarioAlteracao,DataAlteracao,DataCriacao,UsuarioAlteracao,Observacao,Ativo,Versao")] Funcionario funcionario)
        {
            funcionario.Ativo = true;
            funcionario.DataAlteracao = DateTime.Now;
            funcionario.UsuarioAlteracao = User.Identity.Name;

            if (ModelState.IsValid)
            {

                db.Entry(funcionario).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Cargo = new SelectList(db.Cargo.ToList(), "CargoID", "Nome", funcionario.CargoID);
            ViewBag.Empresa = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.EmpresaID);
            ViewBag.Empresa2 = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.Empresa2ID);
            ViewBag.Empresa3 = new SelectList(db.Empresa.ToList(), "EmpresaID", "Nome", funcionario.Empresa3ID);
            ViewBag.PostoTrabalho = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalhoID);
            ViewBag.PostoTrabalho2 = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalho2ID);
            ViewBag.PostoTrabalho3 = new SelectList(db.PostoTrabalho.ToList(), "PostoTrabalhoID", "Nome", funcionario.PostoTrabalho3ID);
            ViewBag.Salario = new SelectList(db.Salario.ToList(), "SalarioID", "Nome", funcionario.SalarioID);
            ViewBag.Lider = new SelectList(db.Funcionario.ToList(), "FuncionarioID", "Nome", funcionario.LiderID);
            ViewBag.SexoList = new SelectList(SexoList, "Key", "Value", funcionario.Sexo);
            ViewBag.UfList = new SelectList(UfList, "Key", "Value", funcionario.EstadoExpedidorRG);
            ViewBag.EstadoCivilList = new SelectList(EstadoCivilList, "Key", "Value", funcionario.EstadoCivil);
            String pathDocumentos = Server.MapPath("~/Documentos/" + funcionario.FuncionarioID);
            ViewBag.Images = System.IO.Directory.EnumerateFiles(pathDocumentos).Select(fn => "~/Documentos/" + funcionario.FuncionarioID + "/" + System.IO.Path.GetFileName(fn));

            //Request.ServerVariables["HTTP_REFERER"];

            return View(funcionario);
        }

        // GET: Folha/Funcionarios/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = await db.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        // POST: Folha/Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Funcionario funcionario = await db.Funcionario.FindAsync(id);
            db.Funcionario.Remove(funcionario);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Upload
        public async Task<ActionResult> UploadFoto(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = await db.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }

            return View("_UploadFoto", funcionario);
        }

        public async Task<ActionResult> UploadDocumentos(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = await db.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }

            String pathDocumentos = Server.MapPath("~/Documentos/" + id);
            ViewBag.Images = System.IO.Directory.EnumerateFiles(pathDocumentos).Select(fn => "~/Documentos/" + id + "/" + System.IO.Path.GetFileName(fn));

            return View("_UploadDocumentos", funcionario);
        }


        [HttpPost, ActionName("UploadFoto")]
        [ValidateAntiForgeryToken]
        public ActionResult UploadFoto(HttpPostedFileBase file)
        {
            int id = Int32.Parse(Request.Form["FuncionarioID"]);
            Funcionario funcionario = db.Funcionario.Find(id);
            funcionario.Ativo = true;
            funcionario.DataAlteracao = DateTime.Now;
            funcionario.UsuarioAlteracao = User.Identity.Name;

            if (file != null)
            {
                String[] strName = file.FileName.Split('.');
                String strExt = strName[strName.Count() - 1];
                string pathSave = String.Format("{0}{1}.{2}", Server.MapPath("~/Fotos/"), "F-" + id, strExt);
                String pathBase = String.Format("~/Fotos/{0}.{1}", "F-" + id, strExt);

                file.SaveAs(pathSave);
                funcionario.Foto = pathBase;
            }

            if (ModelState.IsValid)
            {
                db.Entry(funcionario).State = EntityState.Modified;
                db.SaveChanges();
            }

            return View("_UploadFoto", funcionario);
        }

        [HttpPost, ActionName("UploadDocumentos")]
        [ValidateAntiForgeryToken]
        public ActionResult UploadDocumentos(HttpPostedFileBase file)
        {
            int id = Int32.Parse(Request.Form["FuncionarioID"]);
            string nomeDocumento = Request.Form["nomeDocumento"].Replace(" ", "_");
            Funcionario funcionario = db.Funcionario.Find(id);

            if (file != null)
            {
                String[] strName = file.FileName.Split('.');
                String strExt = strName[strName.Count() - 1];
                String pathDocumentos = Server.MapPath("~/Documentos/" + id);

                bool exists = System.IO.Directory.Exists(pathDocumentos);
                if (!exists)
                    System.IO.Directory.CreateDirectory(pathDocumentos);

                string pathSave = pathDocumentos + "/" + nomeDocumento + "." + strExt;

                file.SaveAs(pathSave);

                ViewBag.Images = System.IO.Directory.EnumerateFiles(pathDocumentos).Select(fn => "~/Documentos/" + id + "/" + System.IO.Path.GetFileName(fn));
            }

            return View("_UploadDocumentos", funcionario);
        }

        [HttpPost, ActionName("DeleteDocumentos")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteDocumentos(HttpPostedFileBase file)
        {
            int id = Int32.Parse(Request.Form["FuncionarioID"]);
            string nomeDocumento = Request.Form["imagem"];
            Funcionario funcionario = db.Funcionario.Find(id);

            String pathDocumentos = Server.MapPath("~/Documentos/" + id);
            string pathSave = pathDocumentos + "/" + nomeDocumento;
            if (nomeDocumento != null)
            {
                System.IO.File.Delete(pathSave);


            }

            ViewBag.Images = System.IO.Directory.EnumerateFiles(pathDocumentos).Select(fn => "~/Documentos/" + id + "/" + System.IO.Path.GetFileName(fn));
            return View("_UploadDocumentos", funcionario);
        }

        #endregion

        #region Relatorios

        public async Task<ActionResult> RelatorioAnalitico(string tipo)
        {
            IQueryable<Funcionario> funcionario;

            if (tipo == "Ativos")
            {
                ViewBag.Tipo = "Ativos";

                funcionario = db.Funcionario.Where(x => x.Admissao != null && x.Demissao == null).Include(f => f.Empresa).Include(f => f.PostoTrabalho);
            }
            else if (tipo == "Inativos")
            {
                ViewBag.Tipo = "Inativos";

                funcionario = db.Funcionario.Where(x => x.Admissao != null && x.Demissao != null).Include(f => f.Empresa).Include(f => f.PostoTrabalho);
            }
            else
            {
                ViewBag.Tipo = "(Todos)";

                funcionario = db.Funcionario.Include(f => f.Empresa).Include(f => f.PostoTrabalho);
            }


            return View(await funcionario.ToListAsync());
        }

        public async Task<ActionResult> RelatorioEmExperiencia(string tipo)
        {
            IQueryable<Funcionario> funcionario;

            var diasExperiencia = DateTime.Now.AddDays(-91);

            funcionario = db.Funcionario.
                Where(x => x.Admissao != null && x.Demissao == null).
                Where(y => y.Admissao >= diasExperiencia).
                Include(f => f.Empresa).
                Include(f => f.PostoTrabalho);




            return View(await funcionario.OrderBy(x => x.Admissao).ToListAsync());
        }


        public async Task<ActionResult> RelatorioGeral(string tipo)
        {
            IQueryable<Funcionario> funcionario;

            if (tipo == "Ativos")
            {
                ViewBag.Tipo = "Ativos";

                funcionario = db.Funcionario.Where(x => x.Admissao != null && x.Demissao == null).Include(f => f.Empresa).Include(f => f.PostoTrabalho);
            }
            else if (tipo == "Inativos")
            {
                ViewBag.Tipo = "Inativos";

                funcionario = db.Funcionario.Where(x => x.Admissao != null && x.Demissao != null).Include(f => f.Empresa).Include(f => f.PostoTrabalho);
            }
            else
            {
                ViewBag.Tipo = "(Todos)";

                funcionario = db.Funcionario.Include(f => f.Empresa).Include(f => f.PostoTrabalho);
            }

            return View(await funcionario.OrderBy(x => x.Nome).ToListAsync());

        }
        #endregion
    }
}
