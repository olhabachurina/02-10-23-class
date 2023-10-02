using _02_10_23_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ElectricCar : IVehicle, IDriveable, IElectricVehicle
{
    public override void Start()
    {
        Console.WriteLine("Electric car started");
    }

    public override void Stop()
    {
        Console.WriteLine("Electric car stopped");
    }

    public override double Speed { get; set; }

    public override double FuelLevel { get; set; }

    public void Accelerate()
    {
        Console.WriteLine("Electric car is accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("Electric car is braking");
    }

    public void Turn()
    {
        Console.WriteLine("Electric car is turning");
    }

    public void ChargeBattery()
    {
        Console.WriteLine("Electric car battery is charging");
    }

    public double BatteryLevel { get; set; }
}