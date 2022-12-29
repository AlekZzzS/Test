using Microsoft.EntityFrameworkCore;
using WebApplication2;

namespace WebApplication2.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }
        public DbSet<NewsModel> News { get; set; }
        public DbSet<LoginModel> Users { get; set; }

    }
    //public class UsersContext : DbContext
    //{
    //    public DbSet<User> Users { get; set; }
    //    public DbSet<Company> Companies { get; set; }
    //    public UsersContext(DbContextOptions<UsersContext> options)
    //        : base(options)
    //    {
    //        Database.EnsureCreated();
    //    }
    //}
}

