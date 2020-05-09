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
    [Table("Dissidio")]
    public class Dissidio : EntidadeBase
    {
        public int DissidioID { get; set; }
        public DateTime Data { get; set; }

       // [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
     //   public virtual Salario salario { get; set; }
    }
}
