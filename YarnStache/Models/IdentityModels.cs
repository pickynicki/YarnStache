using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.Migrations;
using System;

namespace YarnStache.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            //Overriding Default DbInitializer
            Database.SetInitializer(new ApplicationDbInitializer());
        }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<YarnStache.Models.Yarn> Yarns { get; set; }
    }

    public class ApplicationDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        //Seed yarns

        protected override void Seed(ApplicationDbContext context)
        {
            context.Yarns.AddOrUpdate(
                y => y.ColorName,
                new Yarn { Id = Guid.NewGuid(), ColorFamily = "Yellow", ColorName = "Sunshine", Brand = "I Love This Yarn", Weight = "Worsted", FiberType = "Acrylic", DyeLot = "1234", Quantity = 1 },
                new Yarn { Id = Guid.NewGuid(), ColorFamily = "Yellow", ColorName = "Submarine", Brand = "Beatles", Weight = "Light", FiberType = "Cotton", DyeLot = "4321", Quantity = 2 }
            );

            base.Seed(context);
        }
    }
}