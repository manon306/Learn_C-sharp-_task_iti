using EF.DAL.Entities;
using EF_Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;


namespace EF.DAL.DataBase
{
    public class EFCoreDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VSGSPHS\\SQLEXPRESS;Database=FIRSTEF;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        #region Fluent Api لو مليش صلاحيه علي الكود
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(p => p.createOn)
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .ToTable("EmployeeTable",schema:"DEV");

            modelBuilder.Entity<Employee>()
                .Property(p => p.name)
                .HasColumnType("varchar(50)");
            modelBuilder.Entity<Employee>()
                .HasIndex(b => b.salary);

            modelBuilder.Entity<Blog>()
                .HasKey(b => new { b.URL, b.BlogId });

            modelBuilder.Entity<Blog>()
                .Property(b => b.Netsalary)
                .HasComputedColumnSql("[Salary] * 10");


            base.OnModelCreating(modelBuilder);
        }

        #endregion

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> posts { get; set; }



    }
}
