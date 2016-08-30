using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida minhaBebida = new CervejaWeiss();
            minhaBebida = new Witbier(minhaBebida);

            Console.WriteLine("Descrição: {0} - Preço R$ {1}", minhaBebida.getDescricao() , minhaBebida.preco());

            

        }
    }
}
