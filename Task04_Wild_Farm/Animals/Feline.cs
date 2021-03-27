using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Wild_Farm
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, HashSet<string> allowedFoods, double weithModifier, string livingRegion, string breed) :
            base(name, weight, allowedFoods, weithModifier, livingRegion)
        {
            Breed = breed;

        }

        public string Breed { get; private set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
