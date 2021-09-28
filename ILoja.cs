namespace Prj_LetsCode_Avaliacao
{
    public interface ILoja
    {
        string Nome { get; set; }

        Produto produto;
        
        public void Vender();
    
    }
}