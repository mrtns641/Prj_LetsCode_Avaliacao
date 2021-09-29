using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Aeronave
    {
        
        private string modelo;
        private string identificacao;

        public string Modelo
        {
            get { return modelo;}
            set { modelo = value;}
        }
        
        public string Identificacao
        {
            get {return identificacao;}
            set {identificacao = value;}
        }

        // Construtor da Classe Aeronave
        public Aeronave(string modelo, string identificacao){
            this.Modelo = modelo;
            this.Identificacao = identificacao;
        }

    }
}