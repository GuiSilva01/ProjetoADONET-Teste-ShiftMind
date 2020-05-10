using EntityFrameworkFolha.Util;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("Cargo")]
    public class Cargo : EntidadeBase
    {
        public int CargoID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        public string Funcao { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
