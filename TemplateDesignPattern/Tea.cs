using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Tea : CaffeineBeverage
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
            Console.WriteLine("Add Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
