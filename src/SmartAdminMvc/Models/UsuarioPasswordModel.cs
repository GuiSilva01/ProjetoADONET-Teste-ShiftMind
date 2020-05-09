using EntityFrameworkFolha.Util;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SmartAdminMvc.Models
{
    public class UsuarioPasswordModel
    {
        [HiddenInput]
        public string Id { get; set; }

        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemErro.CampoObrigatorio)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}