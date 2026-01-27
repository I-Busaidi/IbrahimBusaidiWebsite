using IbrahimBusaidiWebsite.Data.Users.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IbrahimBusaidiWebsite.Data.Users
{
    public class UsersDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base (options){ }

        public DbSet<Profile> UserProfiles => Set<Profile>();
        public DbSet<Settings> UserSettings => Set<Settings>();
        public DbSet<Address> Addresses => Set<Address>();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Adding user related tables under the same schema for better organization
            builder.HasDefaultSchema("identity");

            // Explicitly adding profile, settings, and addresses tables to other schemas
            builder.Entity<Address>().ToTable("Addresses", "profiles");
            builder.Entity<Profile>().ToTable("UserProfiles", "profiles");

            builder.Entity<Settings>().ToTable("UserSettings", "settings");

            builder.Entity<Address>().HasIndex(a => a.UserId);
        }
    }
}
