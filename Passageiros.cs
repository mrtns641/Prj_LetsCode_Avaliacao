using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Passageiros : Cliente
    {
        private string passaporte;

        private Bagagem bagagem = new Bagagem(0,"");
        public Bagagem Bagagem
        {
            get{return bagagem;}
            set{bagagem=value;}

        }
    
         public Bagagem RecebeBagagem()
        {
            Console.Write("Peso: ");
            double peso;
            Double.TryParse(Console.ReadLine(), out peso);
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Bagagem auxiliar = new Bagagem(peso, descricao);
            return auxiliar;
        }


        public void AddBagagem()
        {
          this.bagagem=(RecebeBagagem());
        }

        public string Passaporte{
            get {return passaporte;}
            set {passaporte = value;}
        }
        public Passageiros(string nome, string cpf, string passaporte) 
                                                    : base(nome, cpf){
            this.Passaporte = passaporte;
        }

    }
}