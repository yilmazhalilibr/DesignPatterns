using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ThirdPartyDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public ThirdPartyDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }


        public void Display()
        {
            Console.WriteLine("ThirdParty : " + _temperature + " F Degrees and " + _humidity + " % humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
