using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Aeronave
    {
        
        private string modelo;
        private int lugares;

        public string Modelo
        {
            get { return modelo;}
            set { modelo = value;}
        }
        
        public int Lugares
        {
            get { return lugares;}
            set { lugares = value;}
        }

        // Construtor da Classe Aeronave
        public Aeronave(string modelo, int lugares){
            this.Modelo = modelo;
            this.Lugares=lugares;

            
            
        }

    }

}