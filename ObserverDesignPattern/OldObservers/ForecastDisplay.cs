using DesignPatterns.ObserverDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {

        public ForecastDisplay(IObservable<WeatherData> observable)
        {

        }
        public void Display()
        {
            Console.WriteLine("Fore cast whaether state : ");
        }



        public void Update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
