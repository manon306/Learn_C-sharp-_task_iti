using Microsoft.EntityFrameworkCore;
namespace MVC_DAY_1.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VSGSPHS\\SQLEXPRESS;Database=MVCDay1G2;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<Student> S { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}