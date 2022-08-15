using DesignPatterns.ObserverDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////// Strategy Desing Pattern Start ///////////////////////
            /* FlyWithWings flyWithWings = new FlyWithWings();
            Duck duck = new DecoyDuck();
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            Console.WriteLine("---------");
            duck.SetFlyBehavior(flyWithWings);  
            duck.PerformFly();*/
            /////////////////////// Strategy Desing Pattern End ///////////////////////
            ///
            /////////////////////// Observer Desing Pattern End ///////////////////////
            /*
            RedFleetBase redFleetBase = new RedFleetBase("Süper işlemciler piyasada");
            redFleetBase.Information = "İşlemciler gelişiyor";

            redFleetBase.AddOperator(new PlatoonOperator { OperatorName = "Azman" });
            redFleetBase.AddOperator(new PlatoonOperator { OperatorName = "Kara Şahin" });
            redFleetBase.AddOperator(new PlatoonOperator { OperatorName = "Kartal Kondu" });

            redFleetBase.Information = "Tüm birlikler Sarı Alarma! Sarı Alarma!";

            Console.WriteLine("");

            redFleetBase.Information = "Emir iptal! Emir iptal!";

            Console.WriteLine("");

            redFleetBase.AddOperator(new TankOperator { TankId = 701 });
            redFleetBase.AddOperator(new TankOperator { TankId = 801 });
            redFleetBase.Information = "Sınır ihlali.";*/
            /////////////////////// Observer Desing Pattern End ///////////////////////











            Console.ReadLine();
        }
    }
}
