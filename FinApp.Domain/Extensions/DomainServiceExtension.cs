using FinApp.Domain.Interfaces.Services;
using FinApp.Domain.Mappging;
using FinApp.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Extensions
{
    public static class DomainServiceExtension
    {
        public static IServiceCollection AddDomainService(this IServiceCollection services)
        {
            services.AddAutoMapper(map => map.AddProfile(typeof(ProfileMap)));

            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IMovimentacaoService, MovimentacaoService>();

            return services;
        }
    }
}
