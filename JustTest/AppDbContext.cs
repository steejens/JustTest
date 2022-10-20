using JustTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace JustTest
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Test>? Test { get; set; }
    }
}
