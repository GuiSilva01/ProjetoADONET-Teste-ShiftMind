using EntityFrameworkFolha.FoPagAux.Entidades;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SmartAdminMvc.Models
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext()
            : base("FoPagAuxDbContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}