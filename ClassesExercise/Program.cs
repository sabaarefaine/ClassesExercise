using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of the Car class
            //Car instead of var because we've created own type
            Car myCar = new Car(); //constructor-helps create new instance of car class

            //Set all of the object’s properties with a value
            //dot notation
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2016;

            //OR
            //object initializer
            var honda = new Car()
            {
                Make = "Honda",
                Model = "Accord",
                Year = 2015
            };

            //OR
            //passing through constructor
            var subaru = new Car("Subaru", "Outback", 2017);

            //Print the values of each property to the Console

            //list with type Car constructor
            var carList = new List<Car>() { myCar, honda, subaru };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
          


        }
    }
}
