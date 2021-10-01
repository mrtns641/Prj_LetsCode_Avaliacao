using System;
using System.Collections.Generic;

namespace Prj_LetsCode_Avaliacao
{
    public class FastFood : Loja, ILoja
    {

        // Método de preparação do pedido.
        public void PrepararPedido(Cliente cliente, Produto produto){
            Console.WriteLine($"Preparando {produto.Nome}.");
            Console.WriteLine($"{cliente.Nome}, o seu pedido está pronto!.");
        }
        
        // Método de venda.
        public virtual void Vender(Cliente cliente, Produto produto){
            Console.WriteLine($"Pedido - {produto.Nome}");
            Console.WriteLine($"Total pago: R$ {produto.Preco}");
            Console.WriteLine($"CPF na nota: {cliente.Cpf}");
            Console.WriteLine($"{Nome} - Processo finalizado!\n");
            PrepararPedido(cliente, produto);
        }
        
        // Construtor da Classe FastFood.
        public FastFood(string nome) : base(nome){}
    }
}