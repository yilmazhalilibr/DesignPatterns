using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            /// 
            /// 
            /// 
            /////////////////////// Strategy Desing Pattern Start ///////////////////////------------------------------
            /*Duck duck = new DecoyDuck();
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();*/
            /////////////////////// Strategy Desing Pattern End ///////////////////////
            ///
            /// 
            /// 
            /// 
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            /// 
            /// 
            /// 
            /////////////////////// Observer Desing Pattern Start ///////////////////////------------------------------
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
            ///
            /// 
            /// 
            /// 
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            /// 
            /// 
            /// 
            /////////////////////// Decorator Desing Pattern Start ///////////////////////------------------------------
            /* Beverage beverage = new Espresso();
             Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());
             Beverage darkRoast = new DarkRoast();
             darkRoast = new Milk(darkRoast);
             darkRoast = new Soy(darkRoast);
             Console.WriteLine(darkRoast.GetDescription() + " $ " + darkRoast.Cost());*/
            /////////////////////// Decorator Desing Pattern End ///////////////////////
            ///
            /// 
            /// 
            /// 
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            /// 
            /// 
            /// 
            /////////////////////// Factory Desing Pattern Start ///////////////////////------------------------------
            ///
            ///
            ///
            ///
            /* PizzaStore store = new NYStylePizzaStore();
               Pizza pizza = store.OrderPizza("cheese", store);*/
            /////////////////////// Factory Desing Pattern End ///////////////////////
            ///
            /// 
            /// 
            /// 
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            /// 
            /// 
            /// 
            /////////////////////// Singleton Desing Pattern Start ///////////////////////------------------------------
            /*
            ChocolateBoiler.Instance.Drain();
            ChocolateBoiler.Instance.Fill();
            ChocolateBoiler.Instance.Boil();
             */
            /////////////////////// Singleton Desing Pattern End ///////////////////////
            ///
            /// 
            /// 
            /// 
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///
            ///
            /////////////////////// Command Desing Pattern Start ///////////////////////------------------------------
            /* SimpleRemoteControl simpleRemoteControl = new SimpleRemoteControl();
             Light light = new Light();
             LightOnCommand lightOn = new LightOnCommand(light);
             GarageDoor door = new GarageDoor();
             GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(door);
             simpleRemoteControl.SetCommand(lightOn);
             simpleRemoteControl.ButtonWasPressed();
             simpleRemoteControl.SetCommand(garageDoorOpen);
             simpleRemoteControl.ButtonWasPressed();*/
            /////////////////////// Command Desing Pattern End ///////////////////////
            ///
            ///
            ///
            ///
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///
            ///
            /////////////////////// Adapter Desing Pattern Start ///////////////////////------------------------------
            /*
             WildTurkey turkey = new WildTurkey();
             Duck duck = new MallardDuck();
             Duck Mallard = new TurkeyAdapter(turkey);
             TestDuck(Mallard);
             */
            /////////////////////// Adapter Desing Pattern End ///////////////////////
            ///
            ///
            ///
            ///
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////




















            Console.ReadLine();
        }
        ///////////////////// Adapter Pattern Method /////////////////////
        //This method for Adapter Design Pattern....
        static void TestDuck(Duck duck)
        {
            duck.PerformQuack();
            duck.PerformFly();
        }
        ///////////////////// Adapter Pattern Method /////////////////////
    }
}
