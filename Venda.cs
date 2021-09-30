using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Venda
    {

        private Cliente cliente;
        private Produto produto;

        public Cliente Cliente{
            get{ return cliente;}
        } 

        public Produto Produto{
            get{ return produto;}
        } 

        //Método construtor da classe Venda
        public Venda(Cliente cliente, Produto produto){
            this.cliente = cliente;
            this.produto = produto;
        }
    }
}