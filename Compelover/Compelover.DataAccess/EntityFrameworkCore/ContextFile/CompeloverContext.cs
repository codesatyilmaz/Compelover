using Compelover.Entities.Tangible;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Compelover.DataAccess.EntityFrameworkCore.ContextFile
{
    public class CompeloverContext : IdentityDbContext<AppUser, AppRole, string>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=CompeloverDb;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
    }
}