using System;
using System.Web.Mvc;
using WeatherForecastApp.Models;

namespace WeatherForecastApp.Controllers
{
    public class HomeController : Controller
    {

        ProjectModel Model = new ProjectModel();

        public HomeController()
        {
            BuildUrl();//вызываем метод, для постройки Url
        }

        public ActionResult Weather()
        {

            return View();
        }
        //методы, для изменения части строки
        public string ReturnNewPathForecast()
        {
            Model.UriBuilder.Path = "forecast";

            return Model.UriBuilder.ToString();
        }

        public string ReturnNewPathWeather()
        {
            Model.UriBuilder.Path = "weather";

            return Model.UriBuilder.ToString();
        }

        

        private void BuildUrl()
        {
            Model.UriBuilder.Scheme = "https";
            Model.UriBuilder.Host = "api.openweathermap.org/data/2.5";
            Model.UriBuilder.Query = $"units=metric&appid={Model.APIKey}";

        }
        
    }
}