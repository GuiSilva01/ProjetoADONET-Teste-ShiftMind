using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    [Table("Flag")]
    public class Flag
    {
        public int FlagID { get; set; }

        public string Nome { get; set; }

        public string Cor { get; set; }

        public string CssClass { get; set; }
    }
}
