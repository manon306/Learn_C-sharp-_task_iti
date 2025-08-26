namespace Student.DAL.DataBase
{
    public class StudentDbContext : DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VSGSPHS\\SQLEXPRESS;Database=NtierTest;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
         }                                                    
        public DbSet<User> Users { get; set; }
        public DbSet<Class> classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
