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
    [Table("Alocacao")]
    public class Alocacao : EntidadeBase
    {
        public int AlocacaoID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int ContratoID { get; set; }

        public virtual Contrato Contrato { get; set; }

        public virtual ICollection<PostoTrabalho> PostosTrabalho { get; set; }

    }
}
