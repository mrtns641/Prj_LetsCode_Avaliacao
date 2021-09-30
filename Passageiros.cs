namespace Prj_LetsCode_Avaliacao
{
    public class Passageiros : Cliente
    {
        private string passaporte;

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