using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Car : Vehicle
    {
        public static int totalCars;
         public int wheels;

        public Car(string make, string model, float prc) : base(make, model, prc)
        {
            totalCars++;
            type = "Car";
            wheels = 4;
        }

       
    }
}
