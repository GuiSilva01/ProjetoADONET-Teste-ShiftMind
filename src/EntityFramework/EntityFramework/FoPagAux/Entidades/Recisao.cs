using EntityFrameworkFolha.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("Recisao")]
    public class Recisao: EntidadeBase
    {
        public int RecisaoID { get; set; }

        //[Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Descricao { get; set; }
        public string FormaLiberacao { get; set; }


        //public int FgtsQtdGuias { get; set; }

        [DisplayFormat(DataFormatString = "{0:#.####}")]
        public decimal? ValorRecisao { get; set; }
        //public decimal FgtsValorUnitarioGuia { get; set; }
        //public decimal FgtsValor { get; set; }

        [DisplayFormat(DataFormatString = "{0:#.####}")]
        public decimal? FgtsValorMulta { get; set; }

        [Required]
        public DateTime DataRecisao { get; set; }
        [Required]
        public DateTime? PrazoPagamentoRecisao { get; set; }
        public DateTime? DataAssinaturaRecisao { get; set; }
        public DateTime? DataPrevisaoSaque { get; set; }
        public DateTime? DataLiberacaoChaveFgts { get; set; }
        public DateTime? DataExameDemissional { get; set; }
        public DateTime? DataDevolucaoUniformes { get; set; }
        public DateTime? DataPagamentoMulta { get; set; }
        //public DateTime DataLiberacaoChaveFgst { get; set; }


        [Required]
        //[Required(ErrorMessage = MensagemErro.CampoAtivo)]
        [Display(Name = "Exame Demissional")]
        public bool ExameDemissional { get; set; }

        [Required]
        [Display(Name = "Multa de 40%")]
        public bool MultaRecisao { get; set; }

        [Required]
        [Display(Name = "Assinatura Recisão")]
        public bool AssinaturaRecisao { get; set; }

        [Required]
        [Display(Name = "Direito à FGTS")]
        public bool Fgts { get; set; }

        [Required]
        [Display(Name = "Devolução de Uniformes")]
        public bool DevolucaoUniformes { get; set; }

        [Required]
        [Display(Name = "Baixa CTPS")]
        public bool BaixaCtps { get; set; }

        [Required]
        [Display(Name = "Chave FGTS Entregue")]
        public bool ChaveFGTSEntregue { get; set; }

        [Required]
        [Display(Name = "Finalizado")]
        public bool Finalizado { get; set; }

        [Required]
        [Display(Name = "Guia Seguro Desemprego")]
        public bool GuiaSeguroDesemprego { get; set; }


        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int FuncionarioID { get; set; }

        public virtual Funcionario Funcionario { get; set; }

        public virtual ICollection<RecisaoValor> RecisaoValor { get; set; }
        public virtual ICollection<FgtsValor> FgtsValor { get; set; }

    }
}
