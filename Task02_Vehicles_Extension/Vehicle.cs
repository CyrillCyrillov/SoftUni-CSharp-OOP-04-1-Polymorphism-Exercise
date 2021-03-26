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

        private const double noEmptyBusIncreased = 1.4;


        
        private double fuelQuantity;

        private double fuelConsumption;

        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
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

        public double FuelQuantity
        {
            get => fuelQuantity;

            private set
            {
                
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid data!");
                }
                
                
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


        public string Drive(double distance, string type)
        {
            double increased = 0;

            if (GetType().Name == "Car") { increased = carIncreased; }
            if (GetType().Name == "Truck") { increased = truckIncreased; }
            if (GetType().Name == "Bus" && type == "NotEmpty") { increased = noEmptyBusIncreased; }


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

            else if(FuelQuantity + fuel * reFuelLost > TankCapacity)
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
