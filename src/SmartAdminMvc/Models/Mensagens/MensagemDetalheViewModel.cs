using System.ComponentModel.DataAnnotations;

namespace SmartAdminMvc.Models.Mensagens
{
    public class MensagemDetalheViewModel
    {
        [Key]
        public int MensagemID { get; set; }

        public string Assunto { get; set; }

        public string NomeRemetente { get; set; }

        public string EmailRemetente { get; set; }

        public string DataHora { get; set; }

        public string Conteudo { get; set; }

        public bool Lida { get; set; }

        public string Flag { get; set; }

        public string BackgroundColor { get; set; }
    }
}