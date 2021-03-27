using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Wild_Farm
{
    public class Owl : Bird
    {
        private const double weithModifier = 0.25;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };


        public Owl(string name, double weight, double wingSize) :
            base(name, weight, allowedFoods, weithModifier, wingSize)
        {
        }

        public override string Sound()
        {
            return "Hoot Hoot";
        }

        
    }
}
