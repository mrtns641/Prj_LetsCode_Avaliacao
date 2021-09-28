using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Aeronave
    {
        
        private string modelo;
        private string identificacao;
        private int lugares;

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

        public int Lugares
        {
            get { return lugares;}
            set { lugares = value;}
        }

        // Construtor da Classe Aeronave
        public Aeronave(string modelo, string identificacao, int lugares){
            this.Modelo = modelo;
            this.Identificacao = identificacao;
            this.Lugares=lugares; 
            
        }

    }

}