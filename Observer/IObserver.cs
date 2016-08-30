using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoObserver
{
    public interface IObserver
    {
        void updateWheather(float temp, float humidity, float pressure);
    }
}
