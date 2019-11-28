using FSL.AppSettingsAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FSL.AppSettingsAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Way6Controller : ControllerBase
    {
        private readonly MySettingsConfiguration _configuration;

        public Way6Controller(
            MySettingsConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public bool Get()
        {
            return _configuration.Parameters.IsProduction;
        }
    }
}
