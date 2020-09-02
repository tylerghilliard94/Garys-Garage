using System;
public class Ram : Vehicle // Gas powered truck
{
    public double FuelCapacity { get; set; }


    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram growls by you. Rrrrrrrruuuuuuuuuuummmmmmmmmbbbbleeeeeee!");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine($"The Ram takes a huge {direction} turn!");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Ram honks its train horn coming to a squealing stop.");
    }

}