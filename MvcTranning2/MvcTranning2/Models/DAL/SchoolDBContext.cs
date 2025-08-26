using Microsoft.EntityFrameworkCore;

namespace MvcTranning2.Models.DAL
{
    public class SchoolDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VSGSPHS\\SQLEXPRESS;Database=MVCDay2G2;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        }
}
