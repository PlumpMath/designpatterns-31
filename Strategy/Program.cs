using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pf = new PatoInfernal();
            pf.Identificar();
            pf.vooComportamento.voo();
            pf.barulhoComportamento.barulho();

            Pato pg = new PatoPagode();
            pg.Identificar();
            pg.vooComportamento.voo();
            pg.setComportamentoVoo(new VooAsaDelta());
            pg.vooComportamento.voo();
        }
    }
}
