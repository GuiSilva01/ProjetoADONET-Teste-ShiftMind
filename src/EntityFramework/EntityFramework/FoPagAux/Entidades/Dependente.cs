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
    [Table("Dependente")]
    public class Dependente : EntidadeBase
    {
        public int DependenteID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }
                
        public string CPF { get; set; }

        public string GrauParentesco { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int FuncionarioID { get; set; }

        public virtual Funcionario Funcionario { get; set; }
        
    }
}
