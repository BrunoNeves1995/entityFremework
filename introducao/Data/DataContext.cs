
using introducao.Model;
using Microsoft.EntityFrameworkCore;

namespace introducao.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Post>? Posts { get; set; }
        // public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Tag>? Tags { get; set; }
        public DbSet<User>? Users { get; set; }
        // public DbSet<UserRole> UserRoles { get; set; } 


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=TERMINAL01\SQLEXPRESS;Database=Blog;User ID=admin;Password=12345;Trusted_Connection=false;TrustServerCertificate=true");
                optionsBuilder.LogTo(Console.WriteLine);
            } 
    }
}