using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    // public Car class
    public class Car
    {
    // constructor
        public Car(string brand, string model, int price) {
            Brand = brand;
            Model = model;
            Price = price;
        }

        public string Brand;
        public string Model;
        public string Year;
        public int Price;
    }
}



