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
    [Table("Grupo")]
    public class Grupo : EntidadeBase
    {
        public int GrupoID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        public int EmpresaID { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
