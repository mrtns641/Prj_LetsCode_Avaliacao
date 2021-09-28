using System;

namespace Prj_LetsCode_Avaliacao
{
    public class SelfService : ILoja
    {
        private Produto produto;

        private string nome;
        public string Nome 
        {
            get { return nome;}
            set { nome = value;}
        }

        // Método de pesagem do prato.
        public void PesarPrato(){
            Console.WriteLine($"Pesando o prato de {produto.Nome}.");
        }
        
        // Método de venda.
        public virtual void Vender(){
            Console.WriteLine($"Produto - prato de {produto.Nome}");
            Console.WriteLine($"Total pago pelo prato {produto.Preco}");
            PesarPrato();
            Console.WriteLine($"{Nome} - Venda concluída! Volte sempre! \n");
        }
        
        // Construtor da Classe SelfService.
        public SelfService(string nome, Produto produto){
            this.Nome = nome;
            this.produto = produto;
        }
    }
}