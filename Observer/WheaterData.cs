using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoObserver
{
    public class WheaterData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;


        public WheaterData()
        {
            observers = new ArrayList();
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = (IObserver)observers[i];
                observer.updateWheather(temperature, humidity, pressure);
            }
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            if (observers.Count >= 0)
            {
                observers.Remove(o);
            } 
        }

        public void mesuramentsChanged()
        {
            notifyObservers();
        }

        public void setMesuarements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            mesuramentsChanged();
        }
    }
}
