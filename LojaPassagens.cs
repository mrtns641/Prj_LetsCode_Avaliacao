using System;

namespace Prj_LetsCode_Avaliacao
{
    public class LojaPassagens : ILoja
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
            PesarPrato();
            Console.WriteLine($"Valor total: R${produto.Preco}");
            Console.WriteLine($"CPF na nota: '{cliente.Cpf}'");
            Console.WriteLine($"{Nome} - Venda concluída! Volte sempre, {cliente.Nome}!\n");
        }
        
        // Construtor da Classe LojaPassagens.
        public LojaPassagens(string nome){
            this.Nome = nome;
        }
    }
}