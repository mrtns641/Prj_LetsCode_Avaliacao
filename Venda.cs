using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Venda
    {

        private Cliente cliente = new Cliente();
        private Produto produto = new Produto();

        public Cliente Cliente{
            get{ return cliente}
        } 

        public Produto Produto{
            get{ return produto}
        } 

        //Método construtor da classe Venda
        public void Venda(Cliente cliente, Produto produto){
            this.cliente = cliente;
            this.produto = produto;
        }
    }
}