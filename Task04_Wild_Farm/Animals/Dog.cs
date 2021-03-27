using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Wild_Farm
{
    public class Dog : Mammal
    {
        private const double weithModifier = 0.4;

        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };



        public Dog(string name, double weight, string livingRegion) :
            base(name, weight, allowedFoods, weithModifier, livingRegion)
        {
        }

        public override string Sound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
