﻿using DesignPatterns.ObserverDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData) 
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }


        public void Display()
        {
            Console.WriteLine("Current conditions : "  + _temperature + " F Degrees and " + _humidity + " % humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
