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
    [Table("Endereco")]
    public class Endereco : EntidadeBase
    {
        public int EnderecoID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Numero { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string CEP { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Estado { get; set; }

        public int? FuncionarioID { get; set; }

        [ForeignKey("FuncionarioID")]
        public virtual Funcionario Funcionario { get; set; }

        public int? EmpresaID { get; set; }

        public int? ClienteID { get; set; }
    }
}
