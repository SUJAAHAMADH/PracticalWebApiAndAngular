using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dto;

namespace WebAPI.Service
{
    public class KelvinToOtherTempService : ITemperatureService
    {
        public TemperatureFormats ConvertTemperature(float kelvin)
        {
            TemperatureFormats temperature = new TemperatureFormats();
            temperature.Celsius = kelvin - 273;
            temperature.Fahrenheit = (kelvin - 273)*9/5+32;
            return temperature;
        }
    }
}
