using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("ValeAlimentacao")]
    public class ValeAlimentacao : EntidadeBase
    {
        public int ValeAlimentacaoID { get; set; }

        public decimal ValorValeAlimentacao { get; set; }
    }
}
