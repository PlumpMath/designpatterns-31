using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoObserver
{
    public class AverageTemperature : IDisplayElement, IObserver
    {
        private float temperature;
        private float humidity;
        private float pressure;
        ISubject weatherData;

        public AverageTemperature(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature = {0}/{1}/{2}", temperature, temperature, temperature);   
        }

        public void updateWheather(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }
    }
}
