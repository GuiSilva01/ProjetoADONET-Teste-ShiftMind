using EntityFrameworkFolha.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    public class FgtsValor
    {
        public int FgtsValorID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public decimal Valor { get; set; }

        public int QuantidadeGuias { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public DateTime DataPagamento { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int RecisaoID { get; set; }

        public virtual Recisao Recisao { get; set; }
    }
}
