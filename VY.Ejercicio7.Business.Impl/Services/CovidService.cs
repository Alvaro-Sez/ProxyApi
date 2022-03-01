using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VY.Ejercicio7.Business.Contracts.Services;
using VY.Ejercicio7.Dtos;

namespace VY.Ejercicio7.Business.Impl.Services
{
    public class CovidService : ICovidService
    {
        private readonly ICovidProxy _covidProxy;

        public CovidService(ICovidProxy covidProxy)
        {
            _covidProxy = covidProxy;
        }

        public async Task<CovidInfoDto> GetHealthInfoAsync(int region, string culture)
        {
            var covidData = await _covidProxy.GetHealthInfoAsync(region, culture);
            if (covidData != null)
            {
                return new CovidInfoDto(covidData);
            }
            return null;
        }
    }
}
