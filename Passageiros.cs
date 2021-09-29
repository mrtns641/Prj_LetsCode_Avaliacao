namespace Prj_LetsCode_Avaliacao
{
    public class Passageiros
    {
        private string nome;
        private string cpf;
        private string passaporte;

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

        public string Passaporte{
            get {return passaporte;}
            set {passaporte = value;}
        }
        public Passageiros(string nome, string cpf, string passaporte){
            this.Nome = nome;
            this.Cpf = cpf;
            this.Passaporte = passaporte;
        }

    }
}