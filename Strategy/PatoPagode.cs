using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PatoPagode : Pato
    {
        public PatoPagode() 
        {
            vooComportamento = new VooModoFoguete();
        }

        public override void Identificar()
        {
            Console.WriteLine( "Pato pagodeiro");
        }
    }
}
