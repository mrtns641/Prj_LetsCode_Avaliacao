using System;

namespace Prj_LetsCode_Avaliacao
{
    public interface ILoja
    {
        string Nome { get; set; }

        void Vender();

        //adiciona um produto na sua lista de produtos
        void AddProduto();
    }
}