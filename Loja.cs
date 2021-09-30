using System;
using System.Collections.Generic;

namespace Prj_LetsCode_Avaliacao
{
    public class Loja
    {
        protected List<Produto> produtos; 
        protected Venda venda;

        protected string nome;
        public string Nome 
        {
            get { return nome;}
            set { nome = value;}
        }

         public Loja(string nome){
            this.Nome = nome;
        }

        protected Produto RetornarProdutoCriado(){
            Produto produto = new Produto(ObterNomeProduto(), 
                            ObterPrecoProduto());
            return produto;
        }

        protected string ObterNomeProduto(){
            Console.WriteLine("Nome:" );
            return Console.ReadLine();
        }

        protected double ObterPrecoProduto(){
            double entradaPreco = 0;
            Console.WriteLine("Preço:" );
            Double.TryParse(Console.ReadLine(), out entradaPreco);
            return entradaPreco;
        }

        //adiciona um produto na sua lista de produtos
        public void AddProduto(){
            produtos.Add(RetornarProdutoCriado());
        }
    }
}