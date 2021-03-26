using System;
using System.Collections.Generic;
using System.Text;

namespace Task03_Raiding
{
    public class Rogue : BaseHero
    {
        private const int basePower = 80;

        public Rogue(string name) : base(name, basePower)
        {

        }



        public override string CastAbility()
        {
            return $"Rogue - {Name} hit for {Power} damage";
        }
    }
}
