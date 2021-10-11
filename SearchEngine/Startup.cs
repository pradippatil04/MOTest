using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SearchEngines.Application.AppServices;
using SearchEngines.Application.Interfaces;
using SearchEngines.Core.Base.Repositories;
using SearchEngines.Core.Repositories;
using SearchEngines.Infrastructure.Base.Repositories;
using SearchEngines.Infrastructure.Data;
using SearchEngines.Infrastructure.Repositories;

namespace SearchEngine
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddDbContext<AppDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("TestString")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ISearchEngineRepository, SearchEngineRepository>();
            services.AddTransient<ISearchEngineService, SearchEngineService>();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SearchEngine", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SearchEngine v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
