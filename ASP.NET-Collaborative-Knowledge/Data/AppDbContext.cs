using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ASP.NET_Collaborative_Knowledge.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Question> Questions { get; set; }
    }
}
