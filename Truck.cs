using _02_10_23_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Truck : IVehicle, IDriveable, ICargoCarrier
{
    public override void Start()
    {
        Console.WriteLine("Truck started");
    }

    public override void Stop()
    {
        Console.WriteLine("Truck stopped");
    }

    public override double Speed { get; set; }

    public override double FuelLevel { get; set; }

    public void Accelerate()
    {
        Console.WriteLine("Truck is accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("Truck is braking");
    }

    public void Turn()
    {
        Console.WriteLine("Truck is turning");
    }

    public void LoadCargo()
    {
        Console.WriteLine("Cargo loaded into the truck");
    }

    public void UnloadCargo()
    {
        Console.WriteLine("Cargo unloaded from the truck");
    }
}

internal interface ICargoCarrier
{
}