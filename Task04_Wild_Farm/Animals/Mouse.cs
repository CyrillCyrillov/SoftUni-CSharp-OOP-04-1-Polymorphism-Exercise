using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Wild_Farm
{
    public class Mouse : Mammal
    {
        private const double weithModifier = 0.1;

        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Vegetable), nameof(Fruit)
        };



        public Mouse(string name, double weight, string livingRegion) :
            base(name, weight, allowedFoods, weithModifier, livingRegion)
        {
        }

        public override string Sound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
