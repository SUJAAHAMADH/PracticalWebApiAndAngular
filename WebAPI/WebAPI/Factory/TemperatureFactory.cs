using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Service;

namespace WebAPI.Factory
{
    public class TemperatureFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public TemperatureFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public ITemperatureService GetTemperatureService(string userSelection)
        {
            if (userSelection == "Celsius")
                return (ITemperatureService)_serviceProvider.GetService(typeof(CelsiusToOtherTempService));
            else if(userSelection == "Kelvin")
                 return (ITemperatureService)_serviceProvider.GetService(typeof(KelvinToOtherTempService));
            else if (userSelection == "Fahrenheit")
                return (ITemperatureService)_serviceProvider.GetService(typeof(FahrenheitToOtherTempService));
            return null;
        }
    }
}
