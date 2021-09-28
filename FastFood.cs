namespace Prj_LetsCode_Avaliacao
{
    public class FastFood : ILoja
    {
        
        public virtual void PrepararPedido(){
            Console.WriteLine($"Preparando {produto.Nome}.");
            Console.WriteLine("Finalizando pedido.");
        }
        
        void Vender(){
            PrepararPedido();
            Console.WriteLine($"{Nome} - Processo finalizado!");
        }
        
        public FastFood(string nome, Produto produto){
            this.Nome = nome;
            this.produto = produto;
        }

    }


}