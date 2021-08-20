using GlobalServices.GlobalServices;
using GlobalServices.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Repositories.Data;
using Repositories.Stock.Interface;
using Repositories.Stock.Repository;
using Repositories.Stock.Service;
using Repositories.Stock.Validations;


namespace Api
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });
            });

            services.AddDbContext<RepositoryEFContext>(opt => opt.UseInMemoryDatabase("Todolist"));
            services.AddScoped<IProductGlobalServices, ProductGlobalServices>();
            services.AddScoped<IProductRepositoryService, ProductRepositoryService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductRepositoryValidate, ProductRepositoryValidate>();
            services.AddScoped<IProductGlobalValidation, ProductGlobalValidation>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
