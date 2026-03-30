using CoffeeRecordsIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoffeeRecordsIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<CoffeeCup> Cups { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>(entity =>
            {
                entity.HasData(new IdentityRole
                {
                    Id = "00000000-0000-0000-0000-000000000001",
                    Name = "Person",
                    NormalizedName = "PERSON"
                });
            });

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.HasData(new ApplicationUser
                {
                    Id = "00000000-0000-0000-0001-000000000001",
                    UserName = "User",
                    NormalizedUserName = "USER",
                    Email = "user@email.cz",
                    NormalizedEmail = "USER@EMAIL.CZ",
                    Name = "User",
                    PasswordHash = "AQAAAAEAACcQAAAAEMtVxw5bQ2e8lz3tE+7qkZBOKtE3lqH4O9aT8+8F6R4Q8K8dR+h5+2z1K0r5sXh7hA==",
                    EmailConfirmed = true
                });
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.HasData(new IdentityUserRole<string>
                {
                    UserId = "00000000-0000-0000-0001-000000000001",
                    RoleId = "00000000-0000-0000-0000-000000000001"
                });
            });

        }
    }
}
