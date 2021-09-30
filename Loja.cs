using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Loja
    {
        private List<Produto> produtos; 

        private string nome;
        public string Nome 
        {
            get { return nome;}
            set { nome = value;}
        }

         public Loja(string nome){
            this.Nome = nome;
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

        //adiciona um produto na sua lista de produtos
        public void AddProduto(){
            produtos.add(RetornarProdutoCriado());
        }
    }
}