using EtnaWin.Models;
using Microsoft.EntityFrameworkCore;
namespace EtnaWin.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; } 
    }
}