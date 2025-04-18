using DoreYab.Application.CourseCategory;
using DoreYab.Domain.CourseCategoryAgg;
using DoreYab.Inferastracture.Efcore;
using DY.Application.Contract.CourseCategory;
using Microsoft.EntityFrameworkCore;

namespace DY.Presentation.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddTransient<ICourseCategoryApplication, CourseCategoryApplication>();
            builder.Services.AddTransient<ICourseCategoryRepository, ICourseCategoryRepository>();
            builder.Services.AddDbContext<DoreYabContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DoreYab"));
            });

            //builder.Services.AddTransient<ICourseCategoryApplication, CourseCategoryApplication>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
