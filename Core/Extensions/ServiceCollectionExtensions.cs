using Core.Utilities.Ioc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    { 
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection, ICoreModule[] modules)
        
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);//Her bir module için modulü yükle 
            }

            return ServiceTool.Create(serviceCollection);//Bizim core katmanında dahil olmak üzere ekleyeceğimiz bütün injectionları bir arada toplayabileceğimiz bir yapıya döndü.
        }

    }
}
