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
    [Table("Cliente")]
    public class Cliente : EntidadeBase
    {
        public int ClienteID { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public string Cnpj { get; set; }

        public string RazaoSocial { get; set; }
        public string InscEstadual { get; set; }
        public string InscMunicipal { get; set; }
        public string NomeContato1 { get; set; }
        public string NomeContato2 { get; set; }
        public string Logradouro { get; set; }
        public string Número { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public string FoneEmpresa { get; set; }
        public string Fax { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string EmailEmpresa { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public int GrupoID { get; set; }

        public virtual Grupo Grupo { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
