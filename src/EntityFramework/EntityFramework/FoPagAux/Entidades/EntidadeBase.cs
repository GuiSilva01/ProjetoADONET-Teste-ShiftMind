using EntityFrameworkFolha.Util;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    public class EntidadeBase
    {
        [DefaultValue("SISTEMA")]
        [HiddenInput(DisplayValue = false)]
        //[Required(ErrorMessage = MensagemErro.CampoUsuarioCriacao)]
        [Display(Name = "Usuário Criação")]
        public string UsuarioCriacao { get; set; }

        [HiddenInput(DisplayValue = false)]
        //[Required(ErrorMessage = MensagemErro.CampoDataCriacao)]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Criação")]
        public DateTime DataCriacao { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Usuário Alteração")]
        public string UsuarioAlteracao { get; set; }

        [HiddenInput(DisplayValue = false)]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Alteração")]
        public DateTime? DataAlteracao { get; set; }

        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoAtivo)]
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Versao { get; set; }
    }
}
