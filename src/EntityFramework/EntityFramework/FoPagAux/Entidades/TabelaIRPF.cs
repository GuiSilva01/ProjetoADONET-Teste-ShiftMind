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
    [Table("TabelaIRPF")]
    public class TabelaIRPF : EntidadeBase
    {
        public int TabelaIRPFID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public Decimal Valor { get; set; }
    }
}
