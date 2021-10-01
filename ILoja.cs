using System;

namespace Prj_LetsCode_Avaliacao
{
    public interface ILoja
    {
        public void Vender(Cliente cliente, Produto produto);
        //void Vender(Venda venda);

    }
}