using Microsoft.EntityFrameworkCore;
using Web_laba3.Models;
namespace Web_laba3.DataContext
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=127.0.0.1;Port=3306;Database=victoria;User=root;Password=vsehorosho123);",
                ServerVersion.AutoDetect("Server=127.0.0.1;Port=3306;Database=victoria;User=root;Password=vsehorosho123);"));
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Tour_short> Tours { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
    }

}
