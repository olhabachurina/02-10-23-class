using _02_10_23_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Motorcycle : IVehicle, IDriveable
{
    public override void Start()
    {
        Console.WriteLine("Motorcycle started");
    }

    public override void Stop()
    {
        Console.WriteLine("Motorcycle stopped");
    }

    public override double Speed { get; set; }

    public override double FuelLevel { get; set; }

    public void Accelerate()
    {
        Console.WriteLine("Motorcycle is accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("Motorcycle is braking");
    }

    public void Turn()
    {
        Console.WriteLine("Motorcycle is turning");
    }
}