using EntityFrameworkFolha.FoPagAux.Entidades;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EntityFrameworkFolha.FoPagAux
{
    public class UsuariosDbContext : IdentityDbContext<Usuario>
    {
        public UsuariosDbContext() : base("FoPagAuxDbContext")
        {

        }
    }
}
