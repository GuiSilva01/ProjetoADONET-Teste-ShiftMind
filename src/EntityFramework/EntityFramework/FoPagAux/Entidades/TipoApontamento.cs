using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("TipoApontamento")]
    public class TipoApontamento
    {
        public int TipoApontamentoID { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public int? MotivoTipoApontamentoID { get; set; }
        public MotivoTipoApontamento MotivoTipoApontamento { get; set; }
    }
}
