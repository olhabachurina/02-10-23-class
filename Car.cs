using _02_10_23_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : IVehicle, IDriveable, ISelfDriving
{
    public override void Start()
    {
        Console.WriteLine("Car started");
    }

    public override void Stop()
    {
        Console.WriteLine("Car stopped");
    }

    public override double Speed { get; set; }

    public override double FuelLevel { get; set; }

    public void Accelerate()
    {
        Console.WriteLine("Car is accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("Car is braking");
    }

    public void Turn()
    {
        Console.WriteLine("Car is turning");
    }

    public void EnableSelfDriving()
    {
        Console.WriteLine("Self-driving enabled for the car");
    }

    public void DisableSelfDriving()
    {
        Console.WriteLine("Self-driving disabled for the car");
    }
}