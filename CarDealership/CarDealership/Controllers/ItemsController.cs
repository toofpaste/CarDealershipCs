using Microsoft.AspNetCore.Mvc;
using cardealership;
using System.Collections.Generic;

namespace cardealership.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("/show")]
        public ActionResult Show()
        {
            List<Car> allItems = Car.GetAll();
            return View(allItems);
        }

        [HttpGet("/show/new")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/show")]
        public ActionResult Create(string model, int price, int miles)
        {
            Car newCar = new Car(model, price, miles);
            return RedirectToAction("Show");
        }

    }
}
