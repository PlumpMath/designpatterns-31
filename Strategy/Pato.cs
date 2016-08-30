using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Pato 
    {
        public IVooComportamento vooComportamento;
        public IBarulhoComportamento barulhoComportamento;
        
        public abstract void Identificar();

        public void setComportamentoVoo(IVooComportamento vc) 
        {
            vooComportamento = vc;
        }

        public void setComportamentoBarulho(IBarulhoComportamento bc)
        {
            barulhoComportamento = bc;
        }

    }
}
