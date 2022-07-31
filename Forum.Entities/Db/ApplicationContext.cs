using Forum.Entities.Models.ForumItems;
using Forum.Entities.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Forum.Entities.Db
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<UserInfo> Users { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-F4JCGAD;Database=Forum1;Trusted_Connection=True;");
        }
    }
}
