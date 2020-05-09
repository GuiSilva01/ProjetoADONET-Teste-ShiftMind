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
    [Table("TipoFerias")]
    public class TipoFerias : EntidadeBase
    {
        public int TipoFeriasID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Descricao { get; set; }

        public virtual ICollection<Ferias> Ferias { get; set; }
    }
}
