using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VY.Ejercicio7.Business.Contracts.Services;
using VY.Ejercicio7.Business.Impl.Services;

namespace VY.Ejercicio7.Business.Impl.Extensions
{
    public static class BusinessRegistrationService
    {
        public static IServiceCollection AddBusinessServices( this IServiceCollection service, IConfiguration configure)
        {
            service.AddTransient<ICovidProxy, CovidProxy>();
            service.AddTransient<ICovidService, CovidService>();
            return service;
        }
    }
}
