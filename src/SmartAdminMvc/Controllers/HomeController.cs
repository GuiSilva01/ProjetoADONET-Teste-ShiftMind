#region Using
using SmartAdminMvc.Services;
using System.Web.Mvc;
#endregion

namespace SmartAdminMvc.Controllers
{
    [CustomAuthorize]
    public class HomeController : BaseController
    {
        // GET: home/index
        public ActionResult Index(int? EscalaID)
        {
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
            var _service = new FuncionarioService();
            var _serviceAlertas = new AlertasService();

            _serviceAlertas.GeraMensagens();

            ViewBag.EscalaID = EscalaID;
            ViewBag.FuncionarioAtual = _service.ObtemUltimoFuncionarioCadastrado()?.FuncionarioID;


            return View();
        }

        // GET: home/inbox
        public ActionResult Inbox()
        {
            return View();
        }

        // GET: home/calendar
        public ActionResult Calendar()
        {
            return View();
        }

        // GET: home/google-map
        public ActionResult GoogleMap()
        {
            return View();
        }

        // GET: home/widgets
        public ActionResult Widgets()
        {
            //[TEST] to initialize the theme setter
            //could be called via jQuery or somewhere...
            Settings.SetValue<string>("config:CurrentTheme", "smart-style-1");

            return View();
        }

        // GET: home/chat
        public ActionResult Chat()
        {
            return View();
        }

        public ActionResult Escalas(int? mes, int? AlocacaoID)
        {
            var _service = new EscalaService();

            var lista = _service.ListaEscalaPorAlocacao(mes, AlocacaoID);

            ViewBag.AlocacaoID = AlocacaoID;
            ViewBag.Mes = mes;

            return PartialView("_Escalas", lista);
        }

        public ActionResult ListaEscalasAlocacao(int? AlocacaoID)
        {
            var _service = new EscalaService();
            ViewBag.AlocacaoID = AlocacaoID;
            return PartialView("_EscalasAlocacao", _service.ListaEscalasAlocacao());
        }

        public ActionResult ListaRelatorioAlocacao(int? mes, int? ano)
        {
            var _service = new EscalaService();
            return PartialView("_RelatorioAlocacao", _service.ListaEscalasAlocacao());
        }

        public ActionResult WidgetDetalhesFuncionario()
        {
            var _service = new FuncionarioService();

            var funcionario = _service.ObtemUltimoFuncionarioCadastrado();

            return PartialView("_WidgetDetalhesFuncionario", funcionario);
        }

        public ActionResult DetalhesFuncionario()
        {
            var _service = new FuncionarioService();

            var funcionario = _service.ObtemUltimoFuncionarioCadastrado();

            return PartialView("_DetalhesFuncionario", funcionario);
        }
    }
}