using System;
using System.Collections.Generic;

namespace Task03_Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroesNumber = int.Parse(Console.ReadLine());

            List<BaseHero> myHeroes = new List<BaseHero>(heroesNumber);


            while (myHeroes.Count != heroesNumber)
            {
                BaseHero nextHero = null;

                string nextName = Console.ReadLine();
                string nextType = Console.ReadLine();

                switch (nextType.ToUpper())
                {
                    case "DRUID":
                        nextHero = new Druid(nextName);
                        myHeroes.Add(nextHero);
                        break;
                    
                    case "PALADIN":
                        nextHero = new Paladin(nextName);
                        myHeroes.Add(nextHero);
                        break;

                    case "ROGUE":
                        nextHero = new Rogue(nextName);
                        myHeroes.Add(nextHero);
                        break;

                    case "WARRIOR":
                        nextHero = new Warrior(nextName);
                        myHeroes.Add(nextHero);
                        break;

                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }
            }
           

            int bossPower = int.Parse(Console.ReadLine());

            int tottalPower = 0;

            foreach (BaseHero element in myHeroes)
            {
                Console.WriteLine(element.CastAbility());
                tottalPower += element.Power; 
            }

            if(tottalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
