using Microsoft.AspNetCore.Mvc;

using programming009.WebAppMvc.Models;

namespace programming009.WebAppMvc.Controllers
{
    public class WeatherForecastController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            WeatherForecastModel model = new WeatherForecastModel();

            //hardcode
            model.Days = new List<WeatherForecastDayModel>
            {
                new WeatherForecastDayModel()
                {
                    Date = new DateOnly(2023, 10, 18),  
                    Icon = "rainy.ico",
                    Temprature = 15
                },
                new WeatherForecastDayModel()
                {
                    Date = new DateOnly(2023, 10, 19),
                    Icon = "sunny-cloudy.ico",
                    Temprature = 13
                },
                new WeatherForecastDayModel()
                {
                    Date = new DateOnly(2023, 10, 20),
                    Icon = "cloudy.ico",
                    Temprature = 10
                },
                new WeatherForecastDayModel()
                {
                    Date = new DateOnly(2023, 10, 21),
                    Icon = "sunny.ico",
                    Temprature = 30
                },
                new WeatherForecastDayModel()
                {
                    Date = new DateOnly(2023, 10, 22),
                    Icon = "cloudy.ico",
                    Temprature = 10
                }
            };

            //ViewData["Hello"] = "It's hello message from controller";
            //ViewBag.Hello2 = "It's second hello message from controller";

            return View(model);
        }
    }
}
