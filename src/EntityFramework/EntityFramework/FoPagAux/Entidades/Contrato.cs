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
    [Table("Contrato")]
    public class Contrato : EntidadeBase
    {
        public int ContratoID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int ClienteID { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<Alocacao> Alocacoes { get; set; }
    }
}
