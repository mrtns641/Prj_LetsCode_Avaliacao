using System;

namespace Prj_LetsCode_Avaliacao
{
    public class FastFood : ILoja
    {
        private List<Produto> produtos;

        private string nome;
        public string Nome 
        {
            get { return nome;}
            set { nome = value;}
        }

        private Produto RetornarProdutoCriado(){
            Produto produto = new Produto(ObterNomeProduto(), 
                            obterPrecoProduto());
            return produto;
        }

        private string ObterNomeProduto(){
            Console.WriteLine($"Nome:" );
            return Console.ReadLine();
        }

        private double ObterPrecoProduto(){
            Console.WriteLine($"Preço:" );
            return Console.ReadLine();
        }

        private void AddProduto(Produto produto){
            produtos.add(RetornarProdutoCriado());
        }

        // Método de preparação do pedido.
        public void PrepararPedido(){
            Console.WriteLine($"Preparando {produto.Nome}.");
            Console.WriteLine($"{cliente.Nome}, o seu pedido está pronto!.");
        }
        
        // Método de venda.
        public virtual void Vender(){
            Console.WriteLine($"Produto - {produto.Nome}");
            Console.WriteLine($"Total pago: R${produto.Preco}");
            PrepararPedido();
            Console.WriteLine($"CPF na nota: '{cliente.Cpf}'");
            Console.WriteLine($"{Nome} - Processo finalizado!\n");
        }
        
        // Construtor da Classe FastFood.
        public FastFood(string nome){
            this.Nome = nome;
        }
    }

}