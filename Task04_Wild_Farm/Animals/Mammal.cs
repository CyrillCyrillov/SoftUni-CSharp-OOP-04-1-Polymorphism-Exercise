using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Wild_Farm
{
    public abstract class Mammal : Animal
    {
               
        protected Mammal(string name, double weight, HashSet<string> allowedFoods, double weithModifier, string livingRegion) :
            base(name, weight, allowedFoods, weithModifier)
        {
            LivingRegion = livingRegion;

        }

        public string LivingRegion { get; private set; }
        public string Breed { get; private set; }
    }
}
