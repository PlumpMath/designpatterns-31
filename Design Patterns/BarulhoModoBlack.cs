using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BarulhoModoBlack : IBarulhoComportamento
    {
        public void barulho() 
        {
            Console.WriteLine("Barulho do shagrath cantando acionado");
        }
    }
}
