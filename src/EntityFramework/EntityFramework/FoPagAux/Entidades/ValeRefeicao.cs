using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("ValeRefeicao")]
    public class ValeRefeicao
    {
        public int ValeRefeicaoID { get; set; }

        public decimal ValorValeRefeicao { get; set; }
    }
}
