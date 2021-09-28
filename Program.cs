using System;

namespace Prj_LetsCode_Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {

        // Implementação da Compra/Venda do ILoja - FastFood e SelfService
            Produto produto1 = new Produto("hamburger", 18.5);
            ILoja loja = new FastFood("McDonalds", produto1);
            loja.Vender();

            Produto produto2 = new Produto("feijoada", 20.5);
            loja = new SelfService("Restaurante", produto2);
            loja.Vender();

            // Implementação da Compra/Venda de Passagem - Cadastro de Clientes, Passagenris e Bagagens
        }
    }
}
