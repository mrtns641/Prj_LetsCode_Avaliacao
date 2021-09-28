using System;

namespace Prj_LetsCode_Avaliacao
{
    public class FastFood : ILoja
    {
        private Produto produto;

        private string nome;
        public string Nome 
        {
            get { return nome;}
            set { nome = value;}
        }

        // Método de preparação do pedido.
        public virtual void PrepararPedido(){
            Console.WriteLine($"Preparando {produto.Nome}.");
            Console.WriteLine("Finalizando pedido.");
        }
        
        // Método de venda.
        public virtual void Vender(){
            Console.WriteLine($"Produto {produto.Nome}");
            Console.WriteLine($"Total pago {produto.Preco}");
            PrepararPedido();
            Console.WriteLine($"{Nome} - Processo finalizado! \n");
        }
        
        // Construtor da Classe FastFood.
        public FastFood(string nome, Produto produto){
            this.Nome = nome;
            this.produto = produto;
        }

    }

}