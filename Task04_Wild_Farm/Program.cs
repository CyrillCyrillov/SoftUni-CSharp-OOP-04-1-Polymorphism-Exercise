using System;
using System.Collections.Generic;
using System.Linq;

namespace Task04_Wild_Farm
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Animal> myAnimals = new List<Animal>();

            while (true)
            {
                string[] dataLineOne = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(dataLineOne[0].ToUpper() == "END")
                {
                    break;
                }

                /*
                    •	Owl – "Hoot Hoot";
                    •	Hen – "Cluck";
                    •	Mouse – "Squeak";
                    •	Dog – "Woof!";
                    •	Cat – "Meow";
                    •	Tiger – "ROAR!!!";

                 */

                Animal nextAnimal = null;

                switch (dataLineOne[0].ToUpper()) // dataLineOne[0] -> Animal TYPE 
                {
                    case "OWL":
                        nextAnimal = new Owl(dataLineOne[1], double.Parse(dataLineOne[2]), double.Parse(dataLineOne[3]));
                        break;

                    case "HEN":
                        nextAnimal = new Hen(dataLineOne[1], double.Parse(dataLineOne[2]), double.Parse(dataLineOne[3]));
                        break;

                    case "MOUSE":
                        nextAnimal = new Mouse(dataLineOne[1], double.Parse(dataLineOne[2]), dataLineOne[3]);
                        break;

                    case "DOG":
                        nextAnimal = new Dog(dataLineOne[1], double.Parse(dataLineOne[2]), dataLineOne[3]);
                        break;

                    case "CAT":
                        nextAnimal = new Cat(dataLineOne[1], double.Parse(dataLineOne[2]), dataLineOne[3], dataLineOne[4]);
                        break;

                    case "TIGER":
                        nextAnimal = new Tiger(dataLineOne[1], double.Parse(dataLineOne[2]), dataLineOne[3], dataLineOne[4]);
                        break;
                    
                    default:
                        Console.WriteLine("Invalid Animal Type!");
                        break;
                }

                

                string[] dataLineTwo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                // dataLIneTwo[0] -> Food Type
                // dataLIneTwo[1] -> Food Quantity

                Food nextFood = null;

                switch (dataLineTwo[0].ToUpper())
                {
                    case "FRUIT":
                        nextFood = new Fruit(int.Parse(dataLineTwo[1]));
                        break;

                    case "MEAT":
                        nextFood = new Meat(int.Parse(dataLineTwo[1]));
                        break;

                    case "SEEDS":
                        nextFood = new Seeds(int.Parse(dataLineTwo[1]));
                        break;

                    case "VEGETABLE":
                        nextFood = new Vegetable(int.Parse(dataLineTwo[1]));
                        break;

                    default:
                        Console.WriteLine("Invalid Food Type!");
                        break;
                }


                
                Console.WriteLine(nextAnimal.Sound());
                
                try
                {

                    nextAnimal.Eat(nextFood);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }    
                
                myAnimals.Add(nextAnimal);
                

            }

            foreach (Animal item in myAnimals)
            {
                Console.WriteLine(item);
            }



            //Console.WriteLine("Hello World!");
        }
    }
}
