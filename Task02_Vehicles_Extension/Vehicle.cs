using System;
using System.Collections.Generic;
using System.Text;

namespace Task02_Vehicles_Extension
{
    public abstract class Vehicle
    {
        private const double carIncreased = 0.9;

        private const double carReFuelLost = 1;

        private const double truckIncreased = 1.6;

        private const double truckReFuelLost = 0.95;

        private const double busIncreased = 1.4;


        private double increased;

        private double reFuelLost;

        private double fuelQuantity;

        private double fuelConsumption;

        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;

            private set
            {
                /*
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid data!");
                }
                */
                
                if (value > tankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        private double FuelConsumption
        {
            get => fuelConsumption;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid data!");
                }

                fuelConsumption = value;
            }

        }

        private double TankCapacity
        {
            get => tankCapacity;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid data!");
                }

                tankCapacity = value;
            }


        }

        public string Drive(double distance)
        {
            double increased = 0;

            if (GetType().Name == "Car") { increased = carIncreased; }
            if (GetType().Name == "Truck") { increased = truckIncreased; }


            double neededFuel = (FuelConsumption + increased) * distance;
            if (neededFuel > FuelQuantity)
            {
                return $"needs refueling";
            }

            FuelQuantity -= neededFuel;
            return $"travelled {distance} km";
        }

        public string DriveEmpty(double distance)
        {
            double increased = 0;


            double neededFuel = (FuelConsumption + increased) * distance;
            if (neededFuel > FuelQuantity)
            {
                return $"needs refueling";
            }

            FuelQuantity -= neededFuel;
            return $"travelled {distance} km";
        }

        public void ReFuel(double fuel)
        {
            double reFuelLost = 1;

            if (GetType().Name == "Car") { reFuelLost = carReFuelLost; }
            if (GetType().Name == "Truck") { reFuelLost = truckReFuelLost; }
            
            if(fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }

            if(FuelQuantity + fuel * reFuelLost > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                FuelQuantity += fuel * reFuelLost;
            }

        }


    }
}
