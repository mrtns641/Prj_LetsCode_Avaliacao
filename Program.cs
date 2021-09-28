using System;

namespace Prj_LetsCode_Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {

        // Implementação da Compra/Venda do ILoja - FastFood e SelfService
            Produto produto1 = new Produto("hamburger", 18.5);
            Cliente cliente1 = new Cliente("Denis");
            ILoja loja = new FastFood("McDonalds", produto1, cliente1);
            loja.Vender();

            Produto produto2 = new Produto("feijoada", 20.5);
            loja = new SelfService("Restaurante", produto2, cliente1);
            loja.Vender();



            // Implementação da Compra/Venda de Passagem - Cadastro de Clientes, Passagenris e Bagagens
        }
    }
}


/*
Criação de Interfaces e Classes
-Lojas*
-Fast Foods*
-Self Service*
Passageiros*
Clientes*
Aeronaves
Passagens


-Realizar processo de compra/venda de pedido em lojas*
-Realizar processo de compra/venda de alimentos self service*
-Realizar processo de preparar pedido Fast Food
-Realizar processo de compra/venda de Fast Food*
Realizar processo de compra/venda de passagem*
Realizar processo de cadastro de Cliente*
Realizar processo de cadastro de passageiro*
Realizar processo de registro de bagagem*
*/