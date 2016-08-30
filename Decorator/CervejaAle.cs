using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoDecorator
{
    public class CervejaAle : Bebida
    {
        public CervejaAle()
        {
            //setDescricao("Cerveja tipo ALE");
            descricao = "Cerveja do tipo ALE";
        }

        public override double preco()
        {
            return 1.99;
        }
    }
}
