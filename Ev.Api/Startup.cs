using Ev.Core.Repositories;
using Ev.Infrastructure.Mapper;
using Ev.Infrastructure.Repositories;
using Ev.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.ComponentModel.Design;

namespace Ev.Api
{
    public class Startup
    {
     
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IEventRepository,EventRepository>();
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<IEventService, EventService>();
            services.AddSingleton(AutoMapperConfig.Initialize());

        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
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
            app.Run();
        }
    }
}

