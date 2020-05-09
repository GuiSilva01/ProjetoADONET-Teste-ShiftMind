using EntityFrameworkFolha.FoPagAux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartAdminMvc.Areas.Folha.Controllers
{
    public class BaseAreaController : Controller
    {
        protected FoPagAuxDbContext db = new FoPagAuxDbContext();

        public List<Models.ListBaseModel> TipoContaBancariaList = new List<Models.ListBaseModel>()
        {
            new Models.ListBaseModel(){Key="Conta Poupança",Value="Conta Poupança"},
            new Models.ListBaseModel(){Key="Conta Corrente",Value="Conta Corrente"},
            new Models.ListBaseModel(){Key="Conta Salário",Value="Conta Salário"},
            new Models.ListBaseModel(){Key="Conta Investimento",Value="Conta Investimento"},
            new Models.ListBaseModel(){Key="Conta Conjunta",Value="Conta Conjunta"}
        };

        public List<Models.ListBaseModel> BancoList = new List<Models.ListBaseModel>()
        {
            new Models.ListBaseModel(){Key="341 Itaú Unibanco S.A.",Value="341 Itaú Unibanco S.A."},
            new Models.ListBaseModel(){Key="104 Caixa Econômica Federal",Value="104 Caixa Econômica Federal"},
            new Models.ListBaseModel(){Key="237 Banco Bradesco S.A.",Value="237 Banco Bradesco S.A."},
            new Models.ListBaseModel(){Key="001 Banco do Brasil S.A.",Value="001 Banco do Brasil S.A."},
            new Models.ListBaseModel(){Key="389 Banco Mercantil do Brasil S.A.",Value="389 Banco Mercantil do Brasil S.A."},
            new Models.ListBaseModel(){Key="033 Banco Santander (Brasil) S.A.",Value="033 Banco Santander (Brasil) S.A."},
            new Models.ListBaseModel(){Key="477 Citibank N.A.",Value="477 Citibank N.A."},
            new Models.ListBaseModel(){Key="062 Hipercard Banco Múltiplo S.A.",Value="062 Hipercard Banco Múltiplo S.A."},
            new Models.ListBaseModel(){Key="399 HSBC Bank Brasil S.A.",Value="399 HSBC Bank Brasil S.A."},
            new Models.ListBaseModel(){Key="318 Banco BMG S.A.",Value="318 Banco BMG S.A."},
            new Models.ListBaseModel(){Key="218 Banco Bonsucesso S.A.",Value="218 Banco Bonsucesso S.A."},
            new Models.ListBaseModel(){Key="208 Banco BTG Pactual S.A.",Value="208 Banco BTG Pactual S.A."},
            new Models.ListBaseModel(){Key="745 Banco Citibank S.A.",Value="745 Banco Citibank S.A."},
            new Models.ListBaseModel(){Key="756 Banco Cooperativo do Brasil S.A.",Value="756 Banco Cooperativo do Brasil S.A."},
            new Models.ListBaseModel(){Key="748 Banco Cooperativo Sicredi S.A.",Value="748 Banco Cooperativo Sicredi S.A."},
            new Models.ListBaseModel(){Key="003 Banco da Amazônia S.A.",Value="003 Banco da Amazônia S.A."},
            new Models.ListBaseModel(){Key="707 Banco Daycoval S.A.",Value="707 Banco Daycoval S.A."},
            new Models.ListBaseModel(){Key="024 Banco de Pernambuco S.A.",Value="024 Banco de Pernambuco S.A."},
            new Models.ListBaseModel(){Key="047 Banco do Estado de Sergipe S.A.",Value="047 Banco do Estado de Sergipe S.A."},
            new Models.ListBaseModel(){Key="037 Banco do Estado do Pará S.A.",Value="037 Banco do Estado do Pará S.A."},
            new Models.ListBaseModel(){Key="039 Banco do Estado do Piauí S.A.",Value="039 Banco do Estado do Piauí S.A."},
            new Models.ListBaseModel(){Key="041 Banco do Estado do Rio Grande do Sul S.A.",Value="041 Banco do Estado do Rio Grande do Sul S.A."},
            new Models.ListBaseModel(){Key="004 Banco do Nordeste do Brasil S.A.",Value="004 Banco do Nordeste do Brasil S.A."},
            new Models.ListBaseModel(){Key="224 Banco Fibra S.A.",Value="224 Banco Fibra S.A."},
            new Models.ListBaseModel(){Key="063 Banco Ibi S.A.",Value="063 Banco Ibi S.A."},
            new Models.ListBaseModel(){Key="074 Banco J. Safra S.A.",Value="074 Banco J. Safra S.A."},
            new Models.ListBaseModel(){Key="623 Banco Panamericano S.A.",Value="623 Banco Panamericano S.A."},
            new Models.ListBaseModel(){Key="611 Banco Paulista S.A.",Value="611 Banco Paulista S.A."},
            new Models.ListBaseModel(){Key="643 Banco Pine S.A.",Value="643 Banco Pine S.A."},
            new Models.ListBaseModel(){Key="724 Banco Porto Seguro S.A.",Value="724 Banco Porto Seguro S.A."},
            new Models.ListBaseModel(){Key="356 Banco Real S.A.",Value="356 Banco Real S.A."},
            new Models.ListBaseModel(){Key="633 Banco Rendimento S.A.",Value="633 Banco Rendimento S.A."},
            new Models.ListBaseModel(){Key="422 Banco Safra S.A.",Value="422 Banco Safra S.A."},
            new Models.ListBaseModel(){Key="655 Banco Votorantim S.A.",Value="655 Banco Votorantim S.A."},
            new Models.ListBaseModel(){Key="492 ING Bank N.V.",Value="492 ING Bank N.V."},
            new Models.ListBaseModel(){Key="409 UNIBANCO - União de Bancos Brasileiros S.A.",Value="409 UNIBANCO - União de Bancos Brasileiros S.A." },
            new Models.ListBaseModel(){Key="212 BANCO ORIGINAL S.A.",Value="212 BANCO ORIGINAL S.A."}

        };

        public List<Models.ListBaseModel> EstadoCivilList = new List<Models.ListBaseModel>()
        {
            new Models.ListBaseModel(){Key="Solteiro",Value="Solteiro"},
            new Models.ListBaseModel(){Key="Casado",Value="Casado"},
            new Models.ListBaseModel(){Key="Viúvo",Value="Viúvo"},
            new Models.ListBaseModel(){Key="Separado",Value="Separado"},
            new Models.ListBaseModel(){Key="Divorciado",Value="Divorciado"}
        };

        public List<Models.ListBaseModel> SexoList = new List<Models.ListBaseModel>()
        {
            new Models.ListBaseModel(){Key="Masculino",Value="Masculino"},
            new Models.ListBaseModel(){Key="Feminino",Value="Feminino"}
        };

        public List<Models.ListBaseModel> UfList = new List<Models.ListBaseModel>()
        {
            new Models.ListBaseModel(){Key="SP",Value="São Paulo"},
            new Models.ListBaseModel(){Key="AC",Value="Acre"},
            new Models.ListBaseModel(){Key="AL",Value="Alagoas"},
            new Models.ListBaseModel(){Key="AP",Value="Amapá"},
            new Models.ListBaseModel(){Key="AM",Value="Amazonas"},
            new Models.ListBaseModel(){Key="BA",Value="Bahia"},
            new Models.ListBaseModel(){Key="CE",Value="Ceará"},
            new Models.ListBaseModel(){Key="DF",Value="Distrito Federal"},
            new Models.ListBaseModel(){Key="ES",Value="Espirito Santo"},
            new Models.ListBaseModel(){Key="GO",Value="Goiás"},
            new Models.ListBaseModel(){Key="MA",Value="Maranhão"},
            new Models.ListBaseModel(){Key="MS",Value="Mato Grosso do Sul"},
            new Models.ListBaseModel(){Key="MT",Value="Mato Grosso"},
            new Models.ListBaseModel(){Key="MG",Value="Minas Gerais"},
            new Models.ListBaseModel(){Key="PA",Value="Pará"},
            new Models.ListBaseModel(){Key="PB",Value="Paraíba"},
            new Models.ListBaseModel(){Key="PR",Value="Paraná"},
            new Models.ListBaseModel(){Key="PE",Value="Pernambuco"},
            new Models.ListBaseModel(){Key="PI",Value="Piauí"},
            new Models.ListBaseModel(){Key="RJ",Value="Rio de Janeiro"},
            new Models.ListBaseModel(){Key="RN",Value="Rio Grande do Norte"},
            new Models.ListBaseModel(){Key="RS",Value="Rio Grande do Sul"},
            new Models.ListBaseModel(){Key="RO",Value="Rondônia"},
            new Models.ListBaseModel(){Key="RR",Value="Roraima"},
            new Models.ListBaseModel(){Key="SC",Value="Santa Catarina"},
            new Models.ListBaseModel(){Key="SE",Value="Sergipe"},
            new Models.ListBaseModel(){Key="TO",Value="Tocantins"}
        };

        public BaseAreaController()
        {
            ViewBag.SexoList = new SelectList(SexoList, "Key", "Value");
            ViewBag.UfList = new SelectList(UfList, "Key", "Value");
            ViewBag.EstadoCivilList = new SelectList(EstadoCivilList, "Key", "Value");
            ViewBag.TipoContaBancariaList = new SelectList(TipoContaBancariaList, "Key", "Value");
            ViewBag.GrauInstrucao = new SelectList(db.GrauInstrucao.ToList(), "GrauInstrucaoID", "Nome");
        }
    }
}