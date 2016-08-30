using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoObserver
{
    public class Program
    {
        static void Main(string[] args)
        {
            WheaterData weatherData = new WheaterData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            AverageTemperature avgTemperature = new AverageTemperature(weatherData);

            weatherData.setMesuarements(80, 65, 30.4f);
            weatherData.setMesuarements(82, 55, 40.4f);
        }
    }
}
