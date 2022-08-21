using DesignPatterns;
using DesignPatterns.CompoundDesignPattern;
using DesignPatterns.IteratorDesignPattern.IteratorPart2;
using DesignPatterns.ProxyDesignPattern.Proxy;
using DesignPatterns.StateDesignPattern;
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
            /*
            Duck duck = new DecoyDuck();
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            */
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
            redFleetBase.Information = "Sınır ihlali.";
            */
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
            /* 
             Beverage beverage = new Espresso();
             Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());
             Beverage darkRoast = new DarkRoast();
             darkRoast = new Milk(darkRoast);
             darkRoast = new Soy(darkRoast);
             Console.WriteLine(darkRoast.GetDescription() + " $ " + darkRoast.Cost());
            */
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
            /* 
             PizzaStore store = new NYStylePizzaStore();
             Pizza pizza = store.OrderPizza("cheese", store);
            */
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
            /*
             SimpleRemoteControl simpleRemoteControl = new SimpleRemoteControl();
             Light light = new Light();
             LightOnCommand lightOn = new LightOnCommand(light);
             GarageDoor door = new GarageDoor();
             GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(door);
             simpleRemoteControl.SetCommand(lightOn);
             simpleRemoteControl.ButtonWasPressed();
             simpleRemoteControl.SetCommand(garageDoorOpen);
             simpleRemoteControl.ButtonWasPressed();
            */
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
            ///
            ///
            ///
            ///
            /////////////////////// Template Desing Pattern Start ///////////////////////------------------------------
            /*
            Coffe coffe = new Coffe();
            coffe.PrepareRecipe();
            */
            /////////////////////// Template Desing Pattern End ///////////////////////
            ///
            ///
            ///
            ///
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///
            ///
            /////////////////////// Iterator & Composite  Desing Pattern Start ///////////////////////------------------------------
            /*
            PersonelAggregate aggregate = new PersonelAggregate();
            aggregate.Add(new Personel { Id = 1, Name = "Gençay", LastName = "Yıldız" });
            aggregate.Add(new Personel { Id = 2, Name = "Ahmet", LastName = "Çakmak" });
            aggregate.Add(new Personel { Id = 3, Name = "Mehmet", LastName = "Aslıbay" });
            aggregate.Add(new Personel { Id = 4, Name = "Ayşe", LastName = "Solmaz" });
            aggregate.Add(new Personel { Id = 5, Name = "Fatma", LastName = "Nurgül" });
            IIterator iterator = aggregate.CreateIterator();
            while (iterator.HasItem())
            {
                Console.WriteLine($"ID : {iterator.CurrentItem().Id}\nAdı : {iterator.CurrentItem().Name}\nSoyadı : {iterator.CurrentItem().LastName}\n*****");
                iterator.NextItem();
            }
            */
            // IENUMATOR
            /*
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            Waitress waitress = new Waitress(pancakeHouseMenu,dinerMenu);
            waitress.PrintMenu();
            */
            /////////////////////// Iterator & Composite Desing Pattern End ///////////////////////
            ///
            ///
            ///
            ///
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///
            ///
            /////////////////////// State Desing Pattern Start ///////////////////////------------------------------
            ///
            /*
            GumballMachine gumballMachine = new GumballMachine(5);
            Console.WriteLine(gumballMachine);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);
            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();
            Console.WriteLine(gumballMachine);
            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);
            */
            /*
            MusicPlayer musicPlayer = new MusicPlayer();
            musicPlayer.Play();
            musicPlayer.Stop();
            Console.WriteLine("*******");
            musicPlayer.Stop();
            Console.WriteLine("*******");
            musicPlayer.Play();
            */
            /////////////////////// State Desing Pattern End ///////////////////////
            ///
            ///
            ///
            ///
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///
            ///
            /////////////////////// Proxy Desing Pattern Start ///////////////////////------------------------------
            /*
            string user, password;
            double price;
            while (true)
            {
                Console.WriteLine("Please type user name");
                user = Console.ReadLine();
                Console.WriteLine("Please type password");
                password = Console.ReadLine();
                Console.WriteLine("Enter the fee you want to pay.");
                price = Convert.ToDouble(Console.ReadLine());
                IBank bank = new ProxyBank(user,password);
                bank.DoPay(price);
                Console.WriteLine("*************************");
            }
            */
            /////////////////////// Proxy Desing Pattern End ///////////////////////
            ///
            ///
            ///
            ///
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///
            ///
            /////////////////////// Compound Desing Pattern Start ///////////////////////------------------------------
            Program similator = new Program();
            AbstractDuckFactory factory = new CountingDuckFactory();
            similator.Simulate(factory);

            /////////////////////// Compound Desing Pattern End ///////////////////////
            ///
            ///
            ///
            ///
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////






            Console.ReadLine();
        }
        ///////////////////// Compound Pattern Method /////////////////////
        //This method for Compound Design Pattern....
        void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());
            Console.WriteLine("\n***Duck Simulator***");
            Flock flockOfDucks = new Flock();
            Flock flockOfMallards = new Flock();


          

            flockOfDucks.Add(mallardDuck);
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);
            
            IQuackable mallardOne = duckFactory.CreateMallardDuck();
            IQuackable mallardTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardThree = duckFactory.CreateMallardDuck();
            IQuackable mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);
            
            flockOfDucks.Add(flockOfMallards);
            Console.WriteLine("Flock Norm");
            Quackologist quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);
            flockOfMallards.RegisterObserver(quackologist);

            Simulate(flockOfDucks);
            Console.WriteLine("Flock Mallard");
            Simulate(flockOfMallards);
           



        }
        void Simulate(IQuackable quackable)
        {
            quackable.Quack();
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
