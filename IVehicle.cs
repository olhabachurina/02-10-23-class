using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_10_23_class
{
    public abstract class IVehicle
    {
        public abstract void Start();


        public abstract void Stop();
        public abstract double Speed { get; set; }
        public abstract double FuelLevel { get; set; }
    }
}

