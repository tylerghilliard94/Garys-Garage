using System;
public class Cessna : Vehicle // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zoooooom!");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine($"The Cessna takes a {direction} turn!");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
    }
}