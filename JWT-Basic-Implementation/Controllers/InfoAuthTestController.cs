using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker;
using JWT_Basic_Implementation.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Basic_Implementation.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InfoAuthTestController : ControllerBase
    {
        
        [HttpGet]
        public List<WeatherDTO> GenerateWeatherData(int count)
        {
            var weatherDataList = new List<WeatherDTO>();

            for (int i = 0; i < count; i++)
            {
                var weatherData = new WeatherDTO
                {
                    Date = DateTime.Now.AddDays(i),
                    Location = Address.City(),
                    Temperature = RandomNumber.Next(0, 100),
                    Humidity = RandomNumber.Next() * 100
                };

                weatherDataList.Add(weatherData);
            }

            return weatherDataList;
        }
    }
}
