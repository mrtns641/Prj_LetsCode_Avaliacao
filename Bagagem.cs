using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Bagagem
    {
        

        private double peso;
        private string descricao;

        public string Descricao
        {
            get { return descricao;}
            set { descricao=value;}
        }
        
        public string Peso
        {
            get { return peso;}
            set { peso = value;}
        }

        // Construtor da Classe Bagagem
        public Bagagem(double peso,string descricao){
            this.Peso = peso;
            this.Descricao=descricao;

            
            
        }

    }

}