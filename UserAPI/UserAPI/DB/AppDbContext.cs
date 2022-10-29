using Microsoft.EntityFrameworkCore;
using UserAPI.Model;

namespace UserAPI.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<UserInfo> Users { get; set; }
    }
}
