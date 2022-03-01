using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VY.Ejercicio7.Business.Contracts.Services;

namespace VY.Ejercicio7.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CovidController : ControllerBase
    {
        private readonly ICovidService covidService;

        public CovidController(ICovidService covidService)
        {
            this.covidService = covidService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCovidInfo([FromQuery] int region, [FromQuery] string lang)
        {
            var data = await covidService.GetHealthInfoAsync(region, lang);
            if (data == null) return NoContent();
            return Ok(data);
        }
    }
}
