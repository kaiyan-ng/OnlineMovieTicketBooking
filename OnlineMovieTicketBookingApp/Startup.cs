using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineMovieTicketBookingApp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMovieTicketBookingApp.Services;
using Microsoft.Extensions.Logging;

namespace OnlineMovieTicketBookingApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IRepo<Movie, int>, MovieRepo>();
            services.AddScoped<IWebRepo<Show, int>, ShowRepo>();
            services.AddScoped<IRepo<int, User>, AdminRepo>();
            services.AddScoped<IRepo<Customer, int>, UserRepo>();
            services.AddScoped<IBookingRepo<Booking, int>, BookingRepo>();
            services.AddScoped<ITicketRepo<Show, int>, TicketRepo>();
            services.AddDbContext<CinemaContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:cinemaCon"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory logger)
        {
            logger.AddLog4Net();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{Controller=Home}/{Action=Index}/{Id?}"
                    );
            });
        }
    }
}
