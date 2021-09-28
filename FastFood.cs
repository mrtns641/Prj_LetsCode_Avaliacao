namespace Prj_LetsCode_Avaliacao
{
    public class FastFood : ILoja
    {

        public virtual void PrepararPedido(){
            Console.WriteLine("Montando hamburguer.");
            Console.WriteLine("Colocando refrigerante.");
            Console.WriteLine("Preparando casquinha de sorvete.");
            Console.WriteLine("Finalizando pedido.");
        }
        
        void Vender(){
            PrepararPedido();
            Console.WriteLine($"{Nome} - Processo finalizado!");
        }
        
        public FastFood(string Nome){
            this.Nome = nome;
        }

    }


}