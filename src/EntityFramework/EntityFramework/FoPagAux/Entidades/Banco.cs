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
    [Table("Banco")]
    public class Banco : EntidadeBase
    {
        public int BancoID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Agencia {get; set;}

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Conta {get;set;}

        public string TipoConta { get; set; }

        public int? FuncionarioID { get; set; }

        public Funcionario Funcionario { get; set; }
    }
}
