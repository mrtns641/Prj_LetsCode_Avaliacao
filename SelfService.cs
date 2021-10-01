using System;
using System.Collections.Generic;

namespace Prj_LetsCode_Avaliacao
{
    public class SelfService : Loja, ILoja
    {
        
        // Método de venda.
        public virtual void Vender(Cliente cliente, Produto produto){
            Console.WriteLine($"\nPrato - {produto.Nome}");
            Console.WriteLine($"Total pago: R$ {produto.Preco}");
            Console.WriteLine($"CPF na nota: {cliente.Cpf}");
            Console.WriteLine($"{Nome} - Processo finalizado!");
            Console.WriteLine($"{cliente.Nome}, agradecemos a preferência, volte sempre!\n");
        }
        
        // Construtor da Classe SelfService.
        public SelfService(string nome) : base(nome){}
    }
}