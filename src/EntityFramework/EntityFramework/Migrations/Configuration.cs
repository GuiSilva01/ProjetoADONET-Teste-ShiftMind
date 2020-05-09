namespace EntityFrameworkFolha.Migrations
{
    using EntityFrameworkFolha.FoPagAux;
    using EntityFrameworkFolha.FoPagAux.Entidades;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FoPagAuxDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FoPagAuxDbContext context)
        {

            var userManager = new UserManager<Usuario>(new UserStore<Usuario>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var rolesList = new List<IdentityRole>() { };

            rolesList.Add(new IdentityRole()
            {
                Id = "1",
                Name = "SISTEMA"
            });

            rolesList.Add(new IdentityRole()
            {
                Id = "2",
                Name = "Gerencia"
            });

            rolesList.Add(new IdentityRole()
            {
                Id = "3",
                Name = "Operacional"
            });

            foreach(var r in rolesList)
            {
                if (context.Roles.Where(x => x.Id == r.Id).Count() == 0)
                {
                    roleManager.Create(r);
                    context.SaveChanges();
                }                
            }

            var user = new Usuario()
            {
                Id = "1",
                UserName = "Admin",
                Nome = "Admin",
                Email = "admin@shiftmind.com.br",
                Ativo = true
            };

            if (context.Users.Where(x => x.Id == user.Id).Count() == 0)
            {
                userManager.Create(user, "teste123");

                context.SaveChanges();

                userManager.AddToRole("1", "SISTEMA");
            }
            context.Flag.Add(new Flag { FlagID = 1, Nome = "Importante", Cor = "lightcoral", CssClass = "bg-color-lightCoral" });
            context.Flag.Add(new Flag { FlagID = 2, Nome = "Do Sistema", Cor = "lightyellow", CssClass = "bg-color-lightYellow" });
            context.Flag.Add(new Flag { FlagID = 3, Nome = "Acompanhar", Cor = "lightblue", CssClass = "bg-color-lightBlue" });
            context.SaveChanges();
            context.MensagemFlag.Add(new MensagemFlag { UsuarioID = "1", MensagemID = 1, FlagID = 2 });
            context.MensagemFlag.Add(new MensagemFlag { UsuarioID = "2", MensagemID = 1, FlagID = 2 });
        }
    }
}
