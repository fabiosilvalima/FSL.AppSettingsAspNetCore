using FSL.AppSettingsAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FSL.AppSettingsAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Way5Controller : ControllerBase
    {
        private readonly IOptions<MySettingsConfiguration> _configuration;

        public Way5Controller(
             IOptions<MySettingsConfiguration> configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public bool Get()
        {
            return _configuration.Value?.Parameters?.IsProduction ?? false;
        }
    }
}
