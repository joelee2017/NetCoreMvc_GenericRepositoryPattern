using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Model.Data;
using Model.Repository;
using Service.Service;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Helper
{
    public static class InJectionExtension
    {
        public static void InJectionByRepository(this IServiceCollection services)
        {
            //services.AddScoped<IGenericRepository<Movie>, GenericRepository<Movie>>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }

        public static void InJectionByService(this IServiceCollection services)
        {
            services.AddScoped<IMoviesService, MoviesService>();
        }

        public static void InJectionByDbContext(this IServiceCollection services, string configuration)
        {
            //services.AddDbContext<MvcMovieContext>(options
            //   => options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));

            services.AddDbContext<MvcMovieContext>(options => options.UseSqlServer(configuration));
        }
    }
}
