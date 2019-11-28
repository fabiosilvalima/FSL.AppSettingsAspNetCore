using FSL.AppSettingsAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FSL.AppSettingsAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Way4Controller : ControllerBase
    {
        private readonly MySettingsConfiguration _settings;

        public Way4Controller(
            IConfiguration configuration)
        {
            _settings = new MySettingsConfiguration();
            configuration.GetSection("MySettings").Bind(_settings);
        }

        [HttpGet]
        public bool Get()
        {
            return _settings?.Parameters?.IsProduction ?? false;
        }
    }
}
