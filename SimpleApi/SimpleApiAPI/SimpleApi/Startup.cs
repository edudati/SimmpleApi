using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using SimpleApi.Model.Context;
using SimpleApi.Services;
using SimpleApi.Services.Implementation;

namespace SimpleApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ApiVersionReader = new HeaderApiVersionReader("version");
            });

            services.AddControllers();

            var connection = Configuration["MySqlConnection:MySqlConnectionString"];
            services.AddDbContext<MySqlContext>(options => options.UseMySql(
                connection,
                new MySqlServerVersion(new Version(5, 7, 38))));

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddScoped<IPersonService, PersonServiceImplementation>();

        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

        }
    }
}
