using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PatoInfernal : Pato
    {
        public PatoInfernal() 
        {
            vooComportamento = new VooModoFoguete();
            barulhoComportamento = new BarulhoModoBlack();

        }
   
        public override void Identificar()
        {
            Console.WriteLine("Pato do hell");
        }
    }
}
