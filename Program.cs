using System;
using System.Collections.Generic;
namespace BasicClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();// Constructor- special member method.
            myCar.Make = "Yugo";
            myCar.Model = "Neon";
            myCar.Year = 1988;


            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "Millenia",
                Year = 2002
            };

            var chevy = new Car("Chevy", "Impala", 2006);

            var carlist = new List<Car>() { myCar, mazda, chevy };
            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make}  {vehicle.Model} {vehicle.Year}");
            }









        }
    }
}
