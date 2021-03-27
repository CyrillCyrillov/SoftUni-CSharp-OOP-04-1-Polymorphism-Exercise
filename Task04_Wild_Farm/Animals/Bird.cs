using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Wild_Farm
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, HashSet<string> allowedFoods, double weithModifier, double wingSize) :
            base(name, weight, allowedFoods, weithModifier)
        {
            WingSize = wingSize;

        }

        public double WingSize { get; private set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, { WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
