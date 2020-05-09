using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SmartAdminMvc.Models
{
    public class GrupoUsuarioModel
    {
        [HiddenInput]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool Selected { get; set; }

        [HiddenInput]
        public int QuantityUsers { get; set; }
    }
}