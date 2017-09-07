using System.Security.Principal;
using System.Threading;
using SecureCo.Data.Models;

namespace SecureCo.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SecureCo.Data.DataContext context)
        {
            if (string.IsNullOrWhiteSpace(Thread.CurrentPrincipal.Identity.Name))
            {
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("Db Admin", "Forms"), new[] { "DBA" });
            }

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            

        }
    }
}
