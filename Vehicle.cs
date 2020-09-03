using System;
namespace GaryGarage
{


    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle takes a {direction} turn!");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle comes to a stop!");
        }
    }
}