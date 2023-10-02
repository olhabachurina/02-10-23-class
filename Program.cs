using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;


class Program
{
    static void Main()
    {
        
        Car car = new Car();
        car.Start();
        car.Accelerate();
        car.Turn();
        car.Stop();

        Truck truck = new Truck();
        truck.Start();
        truck.LoadCargo();
        truck.Accelerate();
        truck.UnloadCargo();
        truck.Stop();

        Motorcycle motorcycle = new Motorcycle();
        motorcycle.Start();
        motorcycle.Accelerate();
        motorcycle.Turn();
        motorcycle.Stop();

        ElectricCar electricCar = new ElectricCar();
        electricCar.Start();
        electricCar.ChargeBattery();
        electricCar.Accelerate();
        electricCar.Turn();
        electricCar.Stop();
    }
}