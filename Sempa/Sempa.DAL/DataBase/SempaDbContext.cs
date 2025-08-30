namespace Sempa.DAL.DataBase
{
    public class SempaDbContext: IdentityDbContext<LogInUser>
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=SempaNteirNew;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        //}
        public SempaDbContext(DbContextOptions<SempaDbContext> options) : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CLass> Classes { get; set; }
    }
}
