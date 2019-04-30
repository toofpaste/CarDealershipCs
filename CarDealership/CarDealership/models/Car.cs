using System;
using System.Collections.Generic;
namespace cardealership
{
    public class Car
    {
        private string Model;
        private int Price;
        private int Miles;
        private static List<Car> _instances = new List<Car> { };

        public Car(string model, int price, int miles)
        {
            Model = model;
            Price = price;
            Miles = miles;
            _instances.Add(this);
        }
        public bool CheckPrice(int price)
        {
            return (price > Price);
        }
        public string getModel()
        {
            return Model;
        }
        public int getPrice()
        {
            return Price;
        }
        public int getMile()
        {
            return Miles;
        }
        public void SetPrice(int price)
        {
            Price = price;
        }

        public static List<Car> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

    }
}
