using DistribuidoraDePicole.Application.Applications;
using DistribuidoraDePicole.Domain.Interfaces.Applications;
using DistribuidoraDePicole.Domain.Interfaces.Repositories;
using DistribuidoraDePicole.Domain.Interfaces.Services;
using DistribuidoraDePicole.Infra.Data.Repositories;
using DistribuidoraDePicole.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DistribuidoraDePicole.IoC
{
    public static class IoCConfig
    {
        public static IServiceCollection ConfigIoC(this IServiceCollection services)
        {
            services.IoCModulos();
            return services;
        }
        public static IServiceCollection IoCModulos(this IServiceCollection services)
        {
            services.AddTransient<IProdutoApplication, ProdutoApplication>();
            services.AddTransient<IProdutoService, ProdutoService>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            services.AddTransient<IVendaApplication, VendaApplication>();
            services.AddTransient<IVendaService, VendaService>();
            services.AddTransient<IVendaRepository, VendaRepository>();
            return services;
        }
    }
}
