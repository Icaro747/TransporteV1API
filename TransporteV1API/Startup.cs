﻿using Microsoft.EntityFrameworkCore;
using TransporteV1API.Data;

namespace TransporteV1API
{
    public class Startup : IStartup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var Connection = Configuration.GetConnectionString("TransporteConnection");
            services.AddDbContext<TransporteContext>(opts => opts.UseMySql(Connection, ServerVersion.AutoDetect(Connection)));
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
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

    public interface IStartup
    {
        IConfiguration Configuration { get; }
        void Configure(WebApplication app, IWebHostEnvironment environment);
        void ConfigureServices(IServiceCollection services);
    }

    public static class StartupExtensions
    {
        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder webAppBuilder) where TStartup: IStartup
        {
            var startup = Activator.CreateInstance(typeof(TStartup), webAppBuilder.Configuration) as IStartup;
            if (startup == null) throw new ArgumentException("Classe Statup.cs inválida");

            startup.ConfigureServices(webAppBuilder.Services);

            var app = webAppBuilder.Build();
            startup.Configure(app, app.Environment);

            app.Run();

            return webAppBuilder;
        }
    }
}
