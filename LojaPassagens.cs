using System;
using System.Collections.Generic;

namespace Prj_LetsCode_Avaliacao
{
    public class LojaPassagens : Loja, ILoja
    {

        private string nome;
        public string Nome 
        {
            get { return nome;}
            set { nome = value;}
        }

        // Método de pesagem do prato.
        public void PesarPrato(){
            Console.WriteLine($"Pesando o prato de .");
        }
        
        // Método de venda.
        public virtual void Vender(Venda venda){
            Console.WriteLine($"Produto - prato de ");
            PesarPrato();
            Console.WriteLine($"Valor total: R$");
            Console.WriteLine($"CPF na nota: ");
            Console.WriteLine($" - Venda concluída! Volte sempre, !\n");
        }
        
        // Construtor da Classe LojaPassagens.
        public LojaPassagens(string nome) : base(nome){}
    }
}