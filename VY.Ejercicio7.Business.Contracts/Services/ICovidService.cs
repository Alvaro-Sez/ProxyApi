﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VY.Ejercicio7.Dtos;

namespace VY.Ejercicio7.Business.Contracts.Services
{
    public interface ICovidService
    {
        Task<CovidInfoDto> GetHealthInfoAsync(int region, string culture);
    }
}
