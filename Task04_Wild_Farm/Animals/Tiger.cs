using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Wild_Farm
{
    class Tiger : Feline
    {
        private const double weithModifier = 1;

        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };



        public Tiger(string name, double weight, string livingRegion, string breed) :
            base(name, weight, allowedFoods, weithModifier, livingRegion, breed)
        {
        }

        public override string Sound()
        {
            return "ROAR!!!";
        }
    }
}
