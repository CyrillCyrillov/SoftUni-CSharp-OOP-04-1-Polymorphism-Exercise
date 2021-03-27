using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Wild_Farm
{
    public class Cat : Feline
    {
        private const double weithModifier = 0.3;

        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat), nameof(Vegetable)
        };



        public Cat(string name, double weight, string livingRegion, string breed) :
            base(name, weight, allowedFoods, weithModifier, livingRegion, breed)
        {
        }

        public override string Sound()
        {
            return "Meow";
        }
    }
}
