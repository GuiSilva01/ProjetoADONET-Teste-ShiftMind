using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("MensagemDestinatario")]
    public class MensagemDestinatario
    {
        public int MensagemDestinatarioID { get; set; }

        public int MensagemID { get; set; }

        public virtual Mensagem Mensagem { get; set; }

        public string DestinatarioID { get; set; }

        public virtual Usuario Destinatario { get; set; }

        public bool Lida { get; set; }
    }
}
