using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VY.Ejercicio7.Business.Contracts.Services;
using VY.Ejercicio7.Dtos;

namespace VY.Ejercicio7.Business.Impl.Services
{
    public class CovidProxy : ICovidProxy
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration configuration;

        public CovidProxy(HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.configuration = configuration;
        }

        public async Task<CovidInfo> GetHealthInfoAsync(int region, string culture)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, string.Format(configuration["CovidUrl"], region, culture)))
            {
                using (var response = await httpClient.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<CovidInfo>(content);
                    }
                    return null;
                }
            }
        }
    }
}
