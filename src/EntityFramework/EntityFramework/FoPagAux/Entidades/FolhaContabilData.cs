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
    [Table("FolhaContabilData")]
   public class FolhaContabilData
    {
        public int Id { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public DateTime DataCalculo { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int Mes { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int Ano { get; set; }
    }
}
