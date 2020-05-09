using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("Mensagem")]
    public class Mensagem : EntidadeBase
    {
        public int MensagemID { get; set; }

        public string Assunto { get; set; }

        public string Conteudo { get; set; }

        public string RemetenteID { get; set; }

        public virtual Usuario Remetente { get; set; }

        public virtual ICollection<MensagemDestinatario> Destinatarios { get; set; }
    }
}
