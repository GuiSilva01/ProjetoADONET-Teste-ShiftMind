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
    [Table("Provento")]
    public class Provento : EntidadeBase
    {
        public int ProventoID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public Decimal Valor { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int TipoOperacaoID { get; set; }

        public TipoOperacao TipoOperacao { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int SalarioID { get; set; }

        public virtual Salario Salario { get; set; }
    }
}
