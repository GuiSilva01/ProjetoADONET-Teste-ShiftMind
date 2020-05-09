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
    [Table("MedidaDisciplinar")]
    public class MedidaDisciplinar : EntidadeBase
    {
        public int MedidaDisciplinarID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Descricao { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public DateTime Data {get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int FuncionarioID { get; set; }

        public virtual Funcionario Funcionario { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int TipoMedidaDisciplinarID { get; set; }

        public virtual TipoMedidaDisciplinar TipoMedidaDisciplinar { get; set; }
    }
}
