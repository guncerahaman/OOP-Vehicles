using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Vehicle //Base or Parent class
    {
        public int id { get; set; }
        public string type;
        public string make { get; set; }
        public string model { get; set; }
        private double Price { get; set; }
        public double price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value >= 0)
                {
                    Price = value;
                }
                else
                {
                    Console.WriteLine("Price can not be negative number");
                }
            }
        }

        public static int totalVehicles = 0;
        public static int counter = 1;
      
        public Vehicle(string make, string model, float prc)
        {
            id = counter++;
            this.make = make;
            this.model = model;
            price = prc;
            totalVehicles++;
            type = "Undefined";
        }

        public static void addVehicle(List<Vehicle> list)
        {

            try
            {
                Console.WriteLine("Please add make of the car");
                string make = Console.ReadLine();
                Console.WriteLine("Please add model of the car");
                string model = Console.ReadLine();
                Console.WriteLine("Please add price of the car");
                float prc = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter M for Motorbike, C for Car");
                char tp = Convert.ToChar(Console.ReadLine().ToUpper());
                if (tp == 'M')
                {
                    Motorbike bike = new Motorbike(make, model, prc);
                    list.Add(bike);
                }
                else if (tp == 'C')
                {
                    Car car = new Car(make, model, prc);
                    list.Add(car);
                }
            }
            catch (Exception w)
            {
                Console.WriteLine(w.Message);
                addVehicle(list);
            }


        }
        public static void displayStock(List<Vehicle> list)
        {

            foreach (Vehicle item in list)
            {
                Console.WriteLine("ID: " + item.id + " Type: " + item.type + " Make : " + item.make + ", Model: " + item.model + ", Price: " + item.price);
            }



        }
        public static void removeVehicle(List<Vehicle> list)
        {

            Console.WriteLine("Remove vehicle by ID");
            int searchValue = Convert.ToInt32(Console.ReadLine());
            bool result = false;
            foreach (Vehicle item in list)
            {
                if (item.id == searchValue)
                {
                    Console.WriteLine(item.make + " " +item.type +" with ID: " + item.id + " was removed");
                    list.Remove(item);
                    totalVehicles--;
                    if (item.type=="Car")
                    {
                        Car.totalCars--;
                    }
                    else if (item.type == "Motorbike")
                    {
                        Motorbike.totalBikes--;
                    }
                    result = true;
                    break;
                }
            }
            if (result == false)
            {
                Console.WriteLine("Vehicle Not Found");

            }



        }

        public static void SearchVehicle(List<Vehicle> list)
        {
            Console.WriteLine("Search vehicle by model or make or type ");
            string searchValue = Console.ReadLine();
            bool result = false;
            foreach (Vehicle item in list)
            {
                if (item.make.ToLower() == searchValue.ToLower() || item.model.ToLower() == searchValue.ToLower() || item.type.ToLower() == searchValue.ToLower())
                {
                    Console.WriteLine("ID: " + item.id + "Type "+ item.type + " Make : " + item.make + ", Model: " + item.model + ", Price: " + item.price);
                    result = true;
                }
            }
            if (result == false)
            {
                Console.WriteLine("Not Found");
            }
        }
        public static void CountWheels(Car cr)
        {
         
            Console.WriteLine(cr.type + " has " + cr.wheels + " wheels");
        }
        public static void CountWheels(Motorbike mb)
        {
            Console.WriteLine(mb.type + " has " + mb.wheels + " wheels");
        }
            public static void LookupVehicle(List<Vehicle> list)
        {
            //    Console.WriteLine("Lookup with ID");
            ////    int searchValue = Convert.ToInt32(Console.ReadLine());
            //    bool result = false;
            //    foreach (Car item in list)
            //    {
            //        if (item.id == searchValue)
            //        {
            //            Console.WriteLine("ID: " + item.id + " Make : " + item.make + ", Model: " + item.model + ", Price: " + item.price);
            //            result = true;
            //            break;
            //        }
            //    }
            //    if (result==false)
            //    {
            //        Console.WriteLine("Not Found");
            //    }


            //for loop implementation
            Console.WriteLine("Please enter an ID: ");
            int userId = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == userId)
                {
                    Console.WriteLine("The vehicle was found: ");
                    Console.WriteLine(list[i].make +" " +list[i].type + " " + list[i].model + " " + list[i].price);
                }
                else if (i == list.Count - 1)
                {
                    Console.WriteLine($"the value of i {i} and count{list.Count}");
                    Console.WriteLine($"The vehicle with id {userId} doesn't exist");
                }
            }


        }
    }
}
