using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkFolha.Util;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    //TODO ControleFinanceiro
    [Table("ControleFinanceiro")]
    public class ControleFinanceiro : EntidadeBase
    {
        public int ControleFinanceiroID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public Decimal Valor { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public DateTime VigenciaInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? VigenciaFim { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int TipoContaID { get; set; }

        public virtual TipoConta TipoConta { get; set; }

        public int FuncionarioID { get; set; }

        public virtual Funcionario Funcionario {get;set;}

    }
}
