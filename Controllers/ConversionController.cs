using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Temparature_Converter.Service;

namespace Temparature_Converter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        [HttpGet(nameof(ConvertFahrenheitToCelcius))]
        public IActionResult ConvertFahrenheitToCelcius(double fahrenheit)
        {
            var far = TemperatureConversion.Fahrenheit(fahrenheit);
            return Ok(far);

        }

        [HttpGet(nameof(ConvertCelciusToFahrenheit))]
        public IActionResult ConvertCelciusToFahrenheit(double Celcius)
        {
            var cel = TemperatureConversion.celsius(Celcius);
            return Ok(cel);
          
        }

    }
}
