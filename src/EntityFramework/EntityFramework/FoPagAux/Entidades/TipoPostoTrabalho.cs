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
    [Table("TipoPostoTrabalho")]
    public class TipoPostoTrabalho : EntidadeBase
    {
        public int TipoPostoTrabalhoID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        public virtual ICollection<PostoTrabalho> PostosTrabalho { get; set; }
    }
}
