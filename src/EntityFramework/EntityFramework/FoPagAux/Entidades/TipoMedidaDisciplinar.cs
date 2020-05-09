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
    [Table("TipoMedidaDisciplinar")]
    public class TipoMedidaDisciplinar : EntidadeBase
    {
        public int TipoMedidaDisciplinarID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        public virtual ICollection<MedidaDisciplinar> MedidaDisciplinar { get; set; }
    }
}
