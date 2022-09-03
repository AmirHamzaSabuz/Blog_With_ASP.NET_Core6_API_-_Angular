using HamzaBlog.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HamzaBlog.API.Data
{
    public class HamzaBlogDbContext : DbContext
    {
        public HamzaBlogDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Post> Posts { get; set; }
    }
}
