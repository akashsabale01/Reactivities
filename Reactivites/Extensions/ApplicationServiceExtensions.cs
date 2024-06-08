using Reactivities.AutoMapperConfig;
using Reactivities.Data;
using Reactivities.Repository.RepositoryImpl;
using Reactivities.Repository;
using Microsoft.EntityFrameworkCore;

namespace Reactivities.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddSwaggerGen();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            }

            );

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
                });
            });

            services.AddScoped<IActivitiesRepository, ActivitiesRepositoryImpl>();

            services.AddAutoMapper(typeof(MappingProfiles));



            return services;
        }
    }
}
