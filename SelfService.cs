using System;

namespace Prj_LetsCode_Avaliacao
{
    public class SelfService : ILoja
    {
        private Produto produto;
        private Cliente cliente;

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
            PesarPrato();
            Console.WriteLine($"Valor total: R${produto.Preco}");
            Console.WriteLine($"{Nome} - Venda concluída! Volte sempre, {cliente.Nome}! \n");
        }
        
        // Construtor da Classe SelfService.
        public SelfService(string nome, Produto produto, Cliente cliente){
            this.Nome = nome;
            this.produto = produto;
            this.cliente = cliente;
        }
    }
}