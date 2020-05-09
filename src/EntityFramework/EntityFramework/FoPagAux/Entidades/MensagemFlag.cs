using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("MensagemFlag")]
    public class MensagemFlag
    {
        public int MensagemFlagID { get; set; }

        public int MensagemID { get; set; }

        public string UsuarioID { get; set; }

        public int FlagID { get; set; }

        public virtual Flag Flag { get; set; }
    }
}
