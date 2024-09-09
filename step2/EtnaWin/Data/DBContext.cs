using User.Models;
using Microsoft.EntityFrameworkCore;
namespace User.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; } 
    }
}