using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverDesignPattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;
        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
        public float GetTemperature()
        {
            return _temperature;
        }
        public float GetHumidity()
        {
            return _humidity;
        }
        public float GetPressure()
        {
            return _pressure;
        }


        public void NotifyObservers()
        {
            foreach (var item in _observers)
            {
                item.Update(_temperature, _humidity, _pressure);    
            }
        }

        public void RegisterObserver(IObserver obs)
        {
            _observers.Add(obs);
        }

        public void RemoveObserver(IObserver obs)
        {
            if (_observers.Count != 0 || _observers != null)
            {
                _observers.Remove(obs);
            }
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }



}
