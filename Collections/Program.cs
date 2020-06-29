using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {   
            Vehicles myCar = new Vehicles();
            myCar.Make = "Toyota Camry";
            Console.WriteLine("I need car number " + myCar.VIN + " stored in my garage.");

            Vehicles carForSale = new Vehicles();
            carForSale.Make = "Ford Mustang";
            //Console.WriteLine("This car number " + carForSale.VIN + " goes on sale " + DateTime.Now + ".");

            Dictionary<string, Vehicles> MyGarage = new Dictionary<string, Vehicles>();
            
            MyGarage.Add(myCar.VIN, myCar);
            MyGarage.Add(myCar.Make, myCar);
            //Console.WriteLine(MyGarage[myCar.Make].VIN);
                        
            Dictionary<string, Vehicles> CarLot = new Dictionary<string, Vehicles>();
            //Console.WriteLine(DateTime.Now.ToString("MMMM dd"));
                        
            CarLot.Add(carForSale.VIN, carForSale);

            Console.WriteLine(CarLot.Values);

            Console.WriteLine("\n" + "What is the model of car " + carForSale.VIN + "? It's going on sale on " + DateTime.Now.ToString("MMMM dd"));

            string userInput = Console.ReadLine().ToUpper();
            
            if (userInput == carForSale.VIN)
            {
                Console.WriteLine("The car model is " + carForSale.Make + ".");
            }
            else if (userInput != carForSale.VIN)
            {
                Console.WriteLine("Invalid VIN");
            }
            
            Console.ReadLine();
        }
    }
}
