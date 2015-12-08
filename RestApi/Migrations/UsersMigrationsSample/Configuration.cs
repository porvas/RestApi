namespace RestApi.Migrations.UsersMigrationsSample
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using RestApi.Infrastructure;
    using RestApi.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\UsersMigrationsSample";
        }

        protected override void Seed(RestApi.Infrastructure.ApplicationDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
 
            var user = new ApplicationUser()
            {
                UserName = "porvas",
                Email = "porfyrios.vasileiou@gmail.com",
                EmailConfirmed = true,
                FirstName = "porvas",
                LastName = "porvas",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-3)
            };
 
            manager.Create(user, "password");
        }
    }
}
