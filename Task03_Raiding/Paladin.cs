using System;
using System.Collections.Generic;
using System.Text;

namespace Task03_Raiding
{
    public class Paladin : BaseHero
    {
        private const int basePower = 100;

        public Paladin(string name) : base(name, basePower)
        {

        }

        public override string CastAbility()
        {
            return $"Paladin - {Name} healed for {Power}";
        }
    }
}
