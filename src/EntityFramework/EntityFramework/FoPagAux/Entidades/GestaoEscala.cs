using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("GestaoEscala")]
    public class GestaoEscala
    {
        public int GestaoEscalaID { get; set; }

        public int Dia { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }

        public int PostoTrabalhoID { get; set; }

        public virtual PostoTrabalho PostoTrabalho { get; set; }

        public int? TipoApontamentoID { get; set; }

        public virtual TipoApontamento TipoApontamento { get; set; }

        public int? FuncionarioID { get; set; }

        public virtual Funcionario Funcionario { get; set; }

        public int? FuncionarioTrocaID { get; set; }

        public virtual Funcionario FuncionarioTroca { get; set; }
    }
}
