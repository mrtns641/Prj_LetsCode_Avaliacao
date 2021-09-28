using System;

namespace Prj_LetsCode_Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("hamburger", 18.5);
            ILoja loja = new FastFood("McDonalds", produto1);
            loja.Vender();

            Produto produto2 = new Produto("feijoada", 20.5);
            loja = new SelfService("Restaurante", produto2);
            loja.Vender();
        }
    }
}
