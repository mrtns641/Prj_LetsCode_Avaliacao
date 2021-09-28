using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Produto
    {
        private string nome;
        private double preco;

        public string Nome{
            get{ return nome;}
            set{ nome = value;}
        }
        public double Preco{
            get{return preco;}
            set{ preco = value;}
        }

        public Produto(string nome, double preco){
            this.Nome = nome;
            this.Preco = preco;
        }

    }
}