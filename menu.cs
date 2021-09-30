using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Menu
    {
        public void MenuInicial()
        {
            Console.WriteLine("1 - Cadastrar Loja");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Cadastrar Cliente");
            Console.WriteLine("4 - Cadastrar Passageiro");
            Console.WriteLine("5 - Cadastrar Aeronave");
            Console.WriteLine("6 - Simular venda");
        
            Console.Write("Digite o número da opção selecionada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            OpcaoSelecionada(opcao);
        }

        public void MenuLojas()
        {
            Console.WriteLine("1 - Fast Food");
            Console.WriteLine("2 - Self Service");
            Console.WriteLine("3 - Loja de passagens");
            Console.WriteLine("0 - Voltar");
        
            Console.Write("Digite o número da opção selecionada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            OpcaoSelecionada(opcao);
        }

        public void OpcaoSelecionadaMenuLojas(int opcao){
            switch (opcao)
            {
                case 1:
                    FastFood fastFood = new FastFood("");
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


        public void OpcaoSelecionadaMenuInicial(int opcao){
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