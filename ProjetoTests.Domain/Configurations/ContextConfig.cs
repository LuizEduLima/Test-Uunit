using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoTests.Domain.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTests.Domain.Configurations
{
    public static class ContextConfig
    {
        public static void AddMyContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<MyContext>();
            services.AddDbContext<MyContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DBTests")));
        }
    }
}
