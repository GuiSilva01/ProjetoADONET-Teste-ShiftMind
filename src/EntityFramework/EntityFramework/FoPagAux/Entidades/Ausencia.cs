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
    [Table("Ausencia")]
    public class Ausencia : EntidadeBase
    {
        public int AusenciaID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int Minutos { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int FuncionarioID { get; set; }

        [ForeignKey("FuncionarioID")]
        public virtual Funcionario Funcionario { get; set; }

        public virtual int? FuncionarioSubstitutoID {get;set;}

        [ForeignKey("FuncionarioSubstitutoID")]
        public virtual Funcionario FuncionarioSubstituto { get; set; }
    }
}
