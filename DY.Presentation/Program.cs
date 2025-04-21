using DoreYab_V1.Application.CourseCategory;
using DoreYab_V1.Domain.CourseCategoryAgg;
using DoreYab_V1.Inferastracture.Efcore;
using DoreYab_V1.Inferastracture.Efcore.Repository;
using DY.Application.Contract.CourseCategory;
using Microsoft.EntityFrameworkCore;

namespace DY.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddTransient<ICourseCategoryApplication, CourseCategoryApplication>();
            builder.Services.AddTransient<ICourseCategoryRepository, CourseCategoryRepository>();
            builder.Services.AddDbContext<DoreYabContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DoreYab"));
            });

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
            name: "areas",
                pattern: "{area:exists}/{controller=Category}/{action=List}/{id?}");
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
