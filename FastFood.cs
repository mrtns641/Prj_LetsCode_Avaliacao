using System;
using System.Collections.Generic;

namespace Prj_LetsCode_Avaliacao
{
    public class FastFood : Loja, ILoja
    {

        private string nome;
        public string Nome 
        {
            get { return nome;}
            set { nome = value;}
        }

        // Método de preparação do pedido.
        public void PrepararPedido(){
            Console.WriteLine($"Preparando .");
            Console.WriteLine($", o seu pedido está pronto!.");
        }
        
        // Método de venda.
        public virtual void Vender(Venda venda){
            Console.WriteLine($"Produto - ");
            Console.WriteLine($"Total pago: R$");
            PrepararPedido();
            Console.WriteLine($"CPF na nota: ");
            Console.WriteLine($" - Processo finalizado!\n");
        }
        
        // Construtor da Classe FastFood.
        public FastFood(string nome) : base(nome){}
    }
}