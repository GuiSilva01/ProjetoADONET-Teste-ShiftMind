using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EntityFrameworkFolha.FoPagAux.Entidades
{
    public class Usuario : IdentityUser
    {
        public string Nome { get; set; }

        public string Foto { get; set; }

        public DateTime? DataAniversario { get; set; }

        public bool Ativo { get; set; }

        //public virtual ICollection<TRole> Roles { get; private set; }
        //public virtual ICollection<TClaim> Claims { get; private set; }
        //public virtual ICollection<TLogin> Logins { get; private set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Usuario> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
         
            return userIdentity;
        }
    }
}
