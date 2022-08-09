using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new car();
            myCar.Make = "Audi";
            myCar.Model = "R6";
            myCar.Year = 2022;

            var mercedes = new car()
            {
                Make = "Mercedes",
                Model = "CLS",
                Year = 2022

            };

            var carList = new List<car>() { myCar, mercedes };

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
