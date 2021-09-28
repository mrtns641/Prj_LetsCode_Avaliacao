using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Passagem
    {
        

        private string nomePassageiro;
        private int assento;

        public string NomePassageiro
        {
            get { return nomePassageiro;}
            set { nomePassageiro = value;}
        }
        
        public string Assento
        {
            get { return assento;}
            set { assento = value;}
        }

        // Construtor da Classe Passagem
        public Passagem(string nomePassageiro, int assento){
            this.NomePassageiro = nomePassageiro;
            this.Assento = assento;

            
            
        }

    }

}