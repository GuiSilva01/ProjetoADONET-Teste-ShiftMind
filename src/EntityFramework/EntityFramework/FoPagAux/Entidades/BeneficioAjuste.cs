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
    [Table("BeneficioAjuste")]
   public class BeneficioAjuste:EntidadeBase
    {
        public int BeneficioAjusteID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public DateTime DataAjuste { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public decimal ValorAjuste { get; set; }

        public virtual Beneficio Beneficio { get; set; }
    }
}
