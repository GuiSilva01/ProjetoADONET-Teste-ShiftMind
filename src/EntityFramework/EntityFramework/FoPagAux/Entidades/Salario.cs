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
    [Table("Salario")]
    public class Salario : EntidadeBase
    {
        public int SalarioID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        public double PisoSalarial { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Referencia { get; set; }

        public virtual ICollection<Provento> Proventos { get; set; }

        public virtual ICollection<Desconto> Descontos { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
