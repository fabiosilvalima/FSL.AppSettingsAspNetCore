using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FSL.AppSettingsAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Way3Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Way3Controller(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public bool Get()
        {
            return _configuration.GetValue<bool>("MySettings:Parameters:IsProduction");
        }
    }
}
