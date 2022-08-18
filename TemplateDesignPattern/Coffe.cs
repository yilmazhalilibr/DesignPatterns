using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Coffe : CaffeineBeverage
    {
        public override void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            CustomerWantsCondiments();

        }


        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
