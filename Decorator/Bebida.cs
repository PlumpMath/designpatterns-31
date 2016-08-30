using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoDecorator
{
    public abstract class Bebida
    {
        public String descricao = "Bebida base";
        public enum cupSize {TALL, GRANDE, VENTI};

        public virtual String getDescricao()
        {
            return descricao;
        }

        public void setDescricao(String pDesc)
        {
            descricao = pDesc;
        }

        public abstract double preco();

    }
}
