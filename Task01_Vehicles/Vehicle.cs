using System;
using System.Collections.Generic;
using System.Text;

namespace Task01_Vehicles
{
    public abstract class Vehicle
    {
        private const double carIncreased = 0.9;

        private const double carReFuelLost = 1;

        private const double truckIncreased = 1.6;

        private const double truckReFuelLost = 0.95;


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
            double increased = 0;

            if(GetType().Name == "Car") { increased = carIncreased; }
            if(GetType().Name == "Truck") { increased = truckIncreased; }


            double neededFuel = (FuelConsumption + increased) * distance;
            if(neededFuel > FuelQuantity)
            {
                return $"needs refueling";
            }

            FuelQuantity -= neededFuel;
            return $"travelled {distance} km";
        }

        public void ReFuel(double fuel)
        {
            double reFuelLost = 0;

            if (GetType().Name == "Car") { reFuelLost = carReFuelLost; }
            if (GetType().Name == "Truck") { reFuelLost = truckReFuelLost; }

            FuelQuantity += fuel * reFuelLost;
        }


    }
}
