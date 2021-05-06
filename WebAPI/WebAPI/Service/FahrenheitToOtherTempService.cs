using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dto;

namespace WebAPI.Service
{
    public class FahrenheitToOtherTempService : ITemperatureService
    {
        public TemperatureFormats ConvertTemperature(float fahrenheit)
        {
            TemperatureFormats temperature = new TemperatureFormats();
            temperature.Kelvin = (fahrenheit-32)*5/9+273;
            temperature.Celsius = (fahrenheit - 32) * 5/9;
            return temperature;
        }
    }
}
