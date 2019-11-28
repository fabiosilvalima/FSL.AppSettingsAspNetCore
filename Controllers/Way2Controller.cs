using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FSL.AppSettingsAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Way2Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Way2Controller(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public bool Get()
        {
            return _configuration.GetSection("MySettings").GetSection("Parameters").GetValue<bool>("IsProduction");
        }
    }
}
