using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dto;

namespace WebAPI.Service
{
    public class CelsiusToOtherTempService : ITemperatureService
    {
        public TemperatureFormats ConvertTemperature(float celsius)
        {
            TemperatureFormats temperature = new TemperatureFormats();
            temperature.Kelvin = celsius + 273;
            temperature.Fahrenheit = celsius * 18 / 10 + 32;
            return temperature;
        }
    }
}
