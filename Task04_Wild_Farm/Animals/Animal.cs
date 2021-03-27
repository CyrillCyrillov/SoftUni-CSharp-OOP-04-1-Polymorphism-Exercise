using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Wild_Farm
{
    public abstract class Animal
    {
        //•	Animal – string Name, double Weight, int FoodEaten;
        // FoodEaten = foodEaten;
        public Animal(string name, double weight, HashSet<string> allowedFoods, double weithModifier)
        {
            Name = name;
            Weight = weight;
            AllowedFoods = allowedFoods;
            WeithModifier = weithModifier;
        }

        private HashSet<string> AllowedFoods { get; set; }

        private double WeithModifier { get; set;}

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }


        public abstract string Sound();

        public void Eat(Food food)
        {
            if(!AllowedFoods.Contains(food.GetType().Name))
            {
                throw new InvalidOperationException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            FoodEaten += food.Quantity;

            Weight += WeithModifier * food.Quantity;
        }
    }
}
