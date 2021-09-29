using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Aeroporto
    {

        private Passageiros passageiro;
        private Bagagem bagagem;

        public void Menu()
        {
            CadastroPassageiro();
            RegistraBagagem();
        }

        public void CadastroPassageiro()
        {
            Console.WriteLine("Antes de prosseguir para sua viagem, vamos precisar de algumas informações, ok?");
            Console.Write("Qual o seu nome? Digite aqui: ");
            string NomePassageiro = Console.ReadLine();
            Console.Write("Qual o seu CPF? Digite aqui: ");
            string CpfPassageiro = Console.ReadLine();
            string PassaportePassageiro;
            Console.Write("Pretende fazer viagens internacionais? Digite 'S' se sim ou 'N' caso contrário:");
            string TemPassaporte = Console.ReadLine();
            TemPassaporte = TemPassaporte.ToUpper();
            if(TemPassaporte == "S" || TemPassaporte == "SIM")
            {
                Console.Write("E qual o seu passaporte? Digite aqui: ");
                PassaportePassageiro = Console.ReadLine();
            }else
            {
                PassaportePassageiro = "0";
            }
    
            Passageiros auxiliar = new Passageiros(NomePassageiro, CpfPassageiro, PassaportePassageiro);
            this.passageiro = auxiliar;
        }

        public void RegistraBagagem()
        {
            Console.Write("Pretende levar bagagem?  Digite 'S' se sim ou 'N' caso contrário:");
            double PesoBagagem = 0;
            string DescricaoBagagem = "";
            string TemBagagem = Console.ReadLine();
            TemBagagem = TemBagagem.ToUpper();
            if(TemBagagem == "S" || TemBagagem == "SIM")
            {
                Console.Write("Qual a descrição da sua bagagem? Digite aqui: ");
                DescricaoBagagem = Console.ReadLine();
                Console.Write("E qual o peso dela em Kg? Digite aqui: ");
                PesoBagagem = Convert.ToDouble(Console.ReadLine());
            }
            
            Bagagem auxiliar = new Bagagem(PesoBagagem, DescricaoBagagem)
            this.bagagem = auxiliar; 
        }


    }
}