using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Wild_Farm
{
    public class Hen : Bird
    {
        private const double weithModifier = 0.35;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable),
            nameof(Fruit),
            nameof(Seeds)
        };


        public Hen(string name, double weight, double wingSize) :
            base(name, weight, allowedFoods, weithModifier, wingSize)
        {
        }

        public override string Sound()
        {
            return "Cluck";
        }


    }
}
