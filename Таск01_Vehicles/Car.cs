using System;
using System.Collections.Generic;
using System.Text;

namespace Таск01_Vehicles
{
    public class Car : Vehicle
    {
        private double increased = 0.9;
        
        private double reFuelLost = 1;

        public Car(double fuelQuantity, double fuelConsumption) : base (fuelQuantity, fuelConsumption)
        {
                
        }
    }
}
