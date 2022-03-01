using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY.Ejercicio7.Dtos
{
    public class CovidInfoDto : CovidInfo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="covidInfo"></param>
        public CovidInfoDto(CovidInfo covidInfo)
        {
            if (covidInfo != null)
            {
                count = covidInfo.count;
                next = covidInfo.next;
                previous = covidInfo.previous;
                results = covidInfo.results;
            }
        }
    }
}
