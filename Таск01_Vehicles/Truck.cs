using System;
using System.Collections.Generic;
using System.Text;

namespace Таск01_Vehicles
{
    public class Truck : Vehicle
    {
        private double increased = 1.6;

        private double reFuelLost = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }

    }
}
