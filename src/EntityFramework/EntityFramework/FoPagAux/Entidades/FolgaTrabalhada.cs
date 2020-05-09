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
    [Table("FolgaTrabalhada")]
    public class FolgaTrabalhada : EntidadeBase
    {
        public int FolgaTrabalhadaID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public DateTime Data {get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int FuncionarioID { get; set; }

        public virtual Funcionario Funcionario { get; set; }
        
    }
}
