using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Motorbike : Vehicle
    {
        public static int totalBikes;
        public int wheels;

        public Motorbike(string make, string model, float prc) : base(make, model, prc)
        {
            totalBikes++;
            type = "Motorbike";
            wheels = 2;
        }


        }
    }

