using System;
using System.Collections.Generic;
using System.Text;

namespace Таск01_Vehicles
{
    public class Vehicle
    {
        private double increased;

        private double reFuelLost;

        private double fuelQuantity;

        private double fuelConsumption;

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;

            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Invalid data!");
                }

                fuelQuantity = value;
            }
        }

        private double FuelConsumption
        {
            get => fuelConsumption;

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Invalid data!");
                }

                fuelConsumption = value;
            }

        }

        public string Drive(double distance)
        {
            double neededFuel = (FuelConsumption + increased) / 100 * distance;
            if(neededFuel > FuelQuantity)
            {
                return $"needs refueling";
            }

            FuelQuantity -= neededFuel;
            return $"travelled {distance} km";
        }

        public void ReFuel(double fuel)
        {
            FuelQuantity += fuel * reFuelLost;
        }


    }
}
