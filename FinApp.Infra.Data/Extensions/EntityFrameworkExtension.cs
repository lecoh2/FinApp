using FinApp.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infra.Data.Extensions
{
    public static class EntityFrameworkExtension
    {
        /// <summary> 
        /// Classe de extensão para configurar as injeções de dependência 
        /// do Entity Framework. 
        /// </summary> 


        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            //ler a connectionString do banco de dados111
            var connectionString = configuration.GetConnectionString("FinApp");
            //injetar as configurações da classe datacontext
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}

