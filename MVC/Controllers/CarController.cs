using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            var cars = new List<Car>()
            {
                new Car 
                {
                    Id = 1,
                    Brand = "Toyota",
                    Model = "Camry",
                    Year = 2020,
                    FuelType = "Gasoline",
                    Price = 24000m
                },
                new Car
                {
                    Id = 2,
                    Brand = "Toyota",
                    Model = "Corolla",
                    Year = 2020,
                    FuelType = "Gasoline",
                    Price = 25000m
                },
            };

            return View(cars);
        }
    }
}
