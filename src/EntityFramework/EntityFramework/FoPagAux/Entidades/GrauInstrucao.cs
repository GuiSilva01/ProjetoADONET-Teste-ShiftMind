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
    [Table("GrauInstrucao")]
    public class GrauInstrucao : EntidadeBase
    {
        public int GrauInstrucaoID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
