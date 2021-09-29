namespace Prj_LetsCode_Avaliacao
{
    public class Passageiros
    {
        private string nome;
        private string cpf;

        public string Nome
        {
            get {return nome;}
            set {nome = value;}
        }

        public string Cpf
        {
            get {return cpf;}
            set {cpf = value;}
        }

        public Passageiros(string nome, string cpf){
            this.Nome = nome;
            this.Cpf = cpf;
        }

    }
}