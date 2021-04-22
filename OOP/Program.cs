using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> StockList = new List<Vehicle>();
            Car obj = new Car("Toyota", "Corolla", 4999);
            StockList.Add(obj);
            Car obj2 = new Car("Vauxhall", "Corsa", 2999);
            StockList.Add(obj2);
            Car obj3 = new Car("Peugeot", "206", 1999);
            StockList.Add(obj3);
            Motorbike obj4 = new Motorbike("Mazda", "xxx", 999);
            StockList.Add(obj4);
            Vehicle.CountWheels(obj2);
            Vehicle.CountWheels(obj4);
            char answer;
            try
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Type A for adding, D for Display, T for Total,R for Remove, S for Search,L for Lookup by ID, X for Exit");
                    Console.WriteLine();
                    answer = Convert.ToChar(Console.ReadLine().ToUpper());
                    switch (answer)
                {
                    case 'A':
                        Vehicle.addVehicle(StockList);
                        break;
                    case 'D':
                       Vehicle.displayStock(StockList);
                        break;
                    case 'T':
                        Console.WriteLine("Total number of Vehicles: " + Vehicle.totalVehicles +" " + Car.totalCars + " Cars " +Motorbike.totalBikes + " Motorbikes" ); 
                        break;
                        case 'S':
                            Vehicle.SearchVehicle(StockList);
                            break;
                        case 'R':
                            Vehicle.removeVehicle(StockList);
                            break;
                        case 'L':
                            Vehicle.LookupVehicle(StockList);
                            break;
                       
                        case 'X':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect option, going back to the main menu...");
                      
                        break;
                }
                } while (answer!='X');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          

            Console.ReadKey();
        }
        
        
    }
}
