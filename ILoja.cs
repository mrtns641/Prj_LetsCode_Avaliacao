namespace Prj_LetsCode_Avaliacao
{
    public interface ILoja
    {
        string Nome { get; set; }
        int Numeracao { get; set; }
        
        public void comprar(); 
        public void vender();
    
      
    }
}