using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Cliente 
    {
        

        private string nome;
        
        public string Nome 
        {
            get { return nome;}
            private set { nome = value;}
        }

        
        public Cliente(string nome){
            this.Nome = nome;
            
        }

    }

}