using IbrahimBusaidiWebsite.Data.Users.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IbrahimBusaidiWebsite.Data.Users
{
    public class UsersDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base (options){ }

        public DbSet<Profile> Profiles => Set<Profile>();
        public DbSet<Settings> Settings => Set<Settings>();
        public DbSet<Address> Addresses => Set<Address>();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Adding user related tables under the same schema for better organization
            builder.HasDefaultSchema("Identity");

            builder.Entity<Address>().HasIndex(a => a.UserId);
        }
    }
}
