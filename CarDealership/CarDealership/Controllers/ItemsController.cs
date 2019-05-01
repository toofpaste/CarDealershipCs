using Microsoft.AspNetCore.Mvc;
using cardealership;
using System.Collections.Generic;

namespace cardealership.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("/Index")]
        public ActionResult Index()
        {
            List<Car> allItems = Car.GetAll();
            return View(allItems);
        }

        [HttpGet("/Index/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/Index")]
        public ActionResult Create(string model, int price, int miles)
        {
            Car newCar = new Car(model, price, miles);
            return RedirectToAction("Index");
        }
        [HttpPost("/Index/delete")]
        public ActionResult DeleteAll()
        {
          Car.ClearAllList();
          return View();
        }

       [HttpGet("/Show/{id}")]
       public ActionResult Show(int id)
       {
         Car car = Car.Find(id);
         return View(car);
       }

    }
}
