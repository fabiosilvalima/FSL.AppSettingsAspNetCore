using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FSL.AppSettingsAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Way1Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Way1Controller(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public bool Get()
        {
            return bool.Parse(_configuration.GetSection("MySettings").GetSection("Parameters").GetSection("IsProduction").Value);
        }
    }
}
