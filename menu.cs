using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Menu
    {
        public void MenuInicial()
        {
            Console.WriteLine("1 - Praça de alimentação");
            Console.WriteLine("2 - Aeroporto");
            Console.WriteLine("0 - Sair do Zerg");
            Console.Write("Digite o número da opção selecionada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (opcao)
            {
                case 1:
                    PracaAlimentacao praca = new PracaAlimentacao();
                    praca.Menu();
                    break;
                case 2:
                    Aeroporto lounge = new Aeroporto();
                    lounge.Menu();
                    break;
                case 0:
                    Console.WriteLine("Agradecemos pela visita! Volte sempre!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida! Favor tentar novamente.");
                    MenuInicial();
                    break;
            }
        }
    }
}