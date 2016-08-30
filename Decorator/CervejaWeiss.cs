using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoDecorator
{
    public class CervejaWeiss : Bebida
    {
        public CervejaWeiss()
        {
            //setDescricao("Cerveja de Trigo");
            descricao = "Cerveja de trigo";
        }

        public override double preco()
        {
            return .89;
        }
    }
}
