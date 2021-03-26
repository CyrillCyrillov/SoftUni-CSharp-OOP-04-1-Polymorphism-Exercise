using System;
using System.Linq;

namespace Task02_Vehicles_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = null;
            Vehicle myTruck = null;
            Vehicle myBus = null;

            for (int i = 1; i <= 3; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (data[0].ToUpper())
                {
                    case "CAR":
                        myCar = new Car(double.Parse(data[1]), double.Parse(data[2]), double.Parse(data[3])); // data[1] -> FuelQuantity,  data[2] -> FuelConsumption data[3] -> TankCapacity
                        break;

                    case "TRUCK":
                        myTruck = new Truck(double.Parse(data[1]), double.Parse(data[2]), double.Parse(data[3])); // data[1] -> FuelQuantity,  data[2] -> FuelConsumption data[3] -> TankCapacity
                        break;

                    case "BUS":
                        myBus = new Bus(double.Parse(data[1]), double.Parse(data[2]), double.Parse(data[3])); // data[1] -> FuelQuantity,  data[2] -> FuelConsumption data[3] -> TankCapacity
                        break;

                    default:
                        throw new ArgumentException("Invalid Input Data!");
                        break;
                }
            }

            int comandsNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= comandsNumber; i++)
            {
                string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (comand[0].ToUpper())
                {
                    case "DRIVE":
                        if (comand[1].ToUpper() == "CAR")
                        {
                            Console.WriteLine("Car " + myCar.Drive(double.Parse(comand[2]), "normal"));
                        }
                        else if (comand[1].ToUpper() == "TRUCK")
                        {
                            Console.WriteLine("Truck " + myTruck.Drive(double.Parse(comand[2]), "normal"));
                        }
                        else
                        {
                            Console.WriteLine("Bus " + myBus.Drive(double.Parse(comand[2]), "NotEmpty"));
                        }
                        break;

                    case "DRIVEEMPTY":
                        Console.WriteLine("Bus " + myBus.Drive(double.Parse(comand[2]), "normal"));
                        break;

                    case "REFUEL":
                        if (comand[1].ToUpper() == "CAR")
                        {
                            myCar.ReFuel(double.Parse(comand[2]));
                        }
                        else if (comand[1].ToUpper() == "TRUCK")
                        {
                            myTruck.ReFuel(double.Parse(comand[2]));
                        }
                        else
                        {
                            myBus.ReFuel(double.Parse(comand[2]));
                        }
                        break;



                    default:
                        break;
                }
            }

            Console.WriteLine($"Car: {(myCar.FuelQuantity):f2}");
            Console.WriteLine($"Truck: {(myTruck.FuelQuantity):f2}");
            Console.WriteLine($"Bus: {(myBus.FuelQuantity):f2}");



            //Console.WriteLine("Hello World!");
        }
    }
}
