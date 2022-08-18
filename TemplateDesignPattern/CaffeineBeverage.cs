using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class CaffeineBeverage
    {
        public virtual void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            CustomerWantsCondiments();
        }
        public abstract void AddCondiments();
        public abstract void Brew();
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        public void CustomerWantsCondiments()
        {
            Console.WriteLine("Do you want to Condiments?");
            Console.WriteLine("Yes for => " + "Y" + "\nNo for => " + "N");
            var answer = Console.ReadLine();
            if (answer.ToLower().Equals("y"))
            {
                AddCondiments();
            }
            Console.WriteLine("Bon appetit!");
        }
    }
}
