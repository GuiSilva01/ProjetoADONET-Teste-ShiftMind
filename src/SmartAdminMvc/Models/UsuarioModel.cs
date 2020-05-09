using EntityFrameworkFolha.Util;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SmartAdminMvc.Models
{
    public class UsuarioModel
    {
        [HiddenInput]
        public string Id { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        [Display(Name = "Grupo de Permissão")]
        public string Grupo { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        public bool Ativo { get; set; }
    }
}