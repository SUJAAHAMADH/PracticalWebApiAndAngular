﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dto;

namespace WebAPI.Service
{
    public interface ITemperatureService
    {
        TemperatureFormats ConvertTemperature(float value);
    }
}
