using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("TipoJornada")]
    public class TipoJornada
    {
        public int TipoJornadaID { get; set; }

        public string Sigla { get; set; }

        public string Nome { get; set; }


    }
}
