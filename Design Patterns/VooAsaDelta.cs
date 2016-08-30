using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class VooAsaDelta : IVooComportamento
    {
        public void voo()
        {
            Console.WriteLine("Voo modo asa delta acionado!");
        }
    }
}
