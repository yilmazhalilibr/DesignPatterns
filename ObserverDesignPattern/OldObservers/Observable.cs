using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Observable : IObserver
    {
        private bool _changed;
        public void AddObserver()
        {

        }
        public void DeleteObserver()
        {

        }
        public void NotifyObservers(object arg)
        {
            if (_changed)
            {
                
            }
        }
        public void SetChanged()
        {
            _changed = true;

        }

        public void Update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
