using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("MensagemExcluida")]
    public class MensagemExcluida
    {
        public int MensagemExcluidaID { get; set; }

        public int MensagemID { get; set; }

        public string UsuarioID { get; set; }
    }
}
