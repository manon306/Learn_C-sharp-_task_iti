using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Sempa.BLL.Mapper;
using Sempa.BLL.Service.Implementation;
using Sempa.DAL.DataBase;
using Sempa.DAL.Repo.Abstraction;
using Sempa.DAL.Repo.Implementation;
using Sempa.PL.Language;

namespace Sempa.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);


            var connectionString = builder.Configuration.GetConnectionString("defaultConnection");

            builder.Services.AddDbContext<SempaDbContext>(options =>
            options.UseLazyLoadingProxies().UseSqlServer(connectionString));
            // Add services to the container.
            builder.Services.AddControllersWithViews()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                        factory.Create(typeof(Resource));
                }); ;
            builder.Services.AddScoped<IUserRepo, UserRepo>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddDbContext<SempaDbContext>();
            builder.Services.AddScoped<IClassService, ClassService>();
            builder.Services.AddScoped<IClassRepo, ClassRepo>();
            builder.Services.AddScoped<IClassService, ClassService>();



            builder.Services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
