using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoDecorator
{
    public class Witbier : BebidaDecorator
    {
        public Bebida bebidaAtual;

        public Witbier(Bebida minhaBebida)
        {
            this.bebidaAtual = minhaBebida;
         

        }

        public override double preco()
        {
            return .50 + bebidaAtual.preco();
        }

        public override string getDescricao()
        {
            return bebidaAtual.getDescricao() + " + Coentro";
        }

     
    }
}
