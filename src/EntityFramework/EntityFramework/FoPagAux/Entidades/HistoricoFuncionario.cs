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
    [Table("HistoricoFuncionario")]
    public class HistoricoFuncionario : EntidadeBase
    {
        public int HistoricoFuncionarioID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string DescricaoHistorico { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int FuncionarioID { get; set; }

        public virtual Funcionario Funcionario { get; set; }

    }
}
