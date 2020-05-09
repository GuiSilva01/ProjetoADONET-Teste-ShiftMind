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
    [Table("PostoTrabalho")]
    public class PostoTrabalho : EntidadeBase
    {
        public int PostoTrabalhoID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int AlocacaoID { get; set; }

        public virtual Alocacao Alocacao { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int TipoPostoTrabalhoID { get; set; }

        public virtual TipoPostoTrabalho TipoPostoTrabalho { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int EscalaID { get; set; }

        public virtual Escala Escala { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int PeriodoID { get; set; }

        public virtual Periodo Periodo { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int QuantidadeFuncionario { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }     

        public virtual ICollection<GestaoEscala> GestaoEscala { get; set; }
    }
}
