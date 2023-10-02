using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_10_23_class
{
    public interface IElectricVehicle
    {
        void ChargeBattery();
        double BatteryLevel { get; set; }
    }
}
