using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class VooModoFoguete : IVooComportamento
    {
        
        public void voo() 
        {
            Console.WriteLine("Modo de voo com foguete acionado");
        }
    }
}
