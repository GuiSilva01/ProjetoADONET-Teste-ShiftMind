using EntityFrameworkFolha.FoPagAux.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SmartAdminMvc.Models.Mensagens
{
    public class NovaMensagemViewModel
    { 
        [Required]
        public List<string> Destinatarios { get; set; }

        public string ResponderPara { get; set; }

        public string DataHora { get; set; }

        public bool FocusTextArea { get; set; }

        [Required]
        public string Assunto { get; set; }

        [AllowHtml]
        [Required]
        public string Conteudo { get; set; }

        public List<Usuario> ListaDestinatarios { get; set; }
    }
}