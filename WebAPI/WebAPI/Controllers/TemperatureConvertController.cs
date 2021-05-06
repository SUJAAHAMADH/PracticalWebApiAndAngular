using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Constants;
using WebAPI.Dto;
using WebAPI.Factory;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureConvertController : ControllerBase
    {
        private readonly ILogger<TemperatureConvertController> _logger;
        private readonly TemperatureFactory _temperatureFactory;
    
        public TemperatureConvertController(TemperatureFactory temperatureFactory, ILogger<TemperatureConvertController> logger)
        {
            _temperatureFactory = temperatureFactory;
            _logger = logger;
        }
        [HttpGet("temperature/{userSelection}/{value}")]
        public ActionResult<TemperatureFormats> GetMovies(string userSelection,float value)
        {
            try
            {

                if (userSelection == Cores.Celsius || userSelection == Cores.Fahrenheit || userSelection == Cores.Kelvin)
                {
                    return Ok(_temperatureFactory.GetTemperatureService(userSelection).ConvertTemperature(value));
                }
                else
                    _logger.LogError("The url or rquest is not correct - Bad Request");
                    return BadRequest();
            }
            catch (Exception e)
            {
                _logger.LogError("Throws Exception {0}",e.Message);
                return BadRequest(e.Message);
            }
        }
    }
}
