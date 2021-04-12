using System;
namespace ClassesExercise
{
    public class Car
    {
        //default constructor 
        public Car()
        {
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        //Create a Make property of type string that is public
        public string Make { get; set; } //get = read set = write

        //Create a Model property of type string that is public
        public string Model { get; set; }

        //Create a Year property of type int that is public
        public int Year { get; set; }
    }
}
