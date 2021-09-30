using System;

namespace Prj_LetsCode_Avaliacao
{
    public class Menu
    {
        Shopping shopping = new Shopping();

        public void MenuInicial()
        {
            Console.WriteLine("1 - Cadastrar Loja");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Cadastrar Cliente");
            Console.WriteLine("4 - Cadastrar Passageiro");
            Console.WriteLine("5 - Cadastrar Aeronave");
            Console.WriteLine("6 - Simular venda");
            OpcaoSelecionadaMenuInicial();
        }

        public void ApresentarSegmento()
        {
            Console.WriteLine("1 - Fast Food");
            Console.WriteLine("2 - Self Service");
            Console.WriteLine("3 - Loja de passagens");
            Console.WriteLine("0 - Voltar");
        }

        private int opcaoSelecionada(){
            Console.Write("Digite o número da opção selecionada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return opcao;
        }

        private void CadastrarLoja(){
            switch (opcaoSelecionada())
            { 
                case 1:
                    Console.WriteLine("Nome do FastFood:");
                    FastFood fastFood = new FastFood(Console.ReadLine());
                    shopping.AddFastFood(fastFood);
                    break;
                    
                case 2:
                    Console.WriteLine("Nome do SelfService:");
                    SelfService selfService = new SelfService
                    (Console.ReadLine());
                    shopping.AddSelfService(selfService);
                    break;

                case 3:
                    Console.WriteLine("Nome da Loja de Passagens:");
                    LojaPassagens lojaPassagens = new LojaPassagens
                    (Console.ReadLine());
                    shopping.AddLojaPassagens(lojaPassagens);
                    break;

                case 0:
                    MenuInicial();
                    break;

                default:
                    Console.WriteLine("Opção inválida! Favor tentar novamente.");
                    CadastrarLoja();
                    break;
            }
        }

        private void CadastrarProduto(){
            string NomeLojaReceberaProduto = "";
            switch (opcaoSelecionada())
            { 
                case 1:
                    shopping.ListarFastFoods();
                    Console.Write("Digite o nome do FastFood que deseja " +
                    "cadastrar o produto:");
                    NomeLojaReceberaProduto = Console.ReadLine();
                    int indexLoja = shopping.FastFoods.FindIndex(loja=>
                    loja.Nome.Equals(NomeLojaReceberaProduto, 
                    StringComparison.InvariantCultureIgnoreCase));
                                            
                    if(indexLoja == -1) {
                        Console.WriteLine("Loja não encontrada, tente novamente");
                        CadastrarProduto();
                    } else {
                        shopping.FastFoods[indexLoja].AddProduto();
                    }
                    break;
                    
                case 2:
                    shopping.ListarSelfServices();
                    Console.Write("Digite o nome do SelfService que deseja " +
                    "cadastrar o produto:");
                    break;

                case 3:
                    shopping.ListarLojasDePassagens();
                    Console.Write("Digite o nome da Loja de passagens que deseja " +
                    "cadastrar o produto:");
                    break;

                case 0:
                    MenuInicial();
                    break;

                default:
                    Console.WriteLine("Opção inválida! Favor tentar novamente.");
                    CadastrarProduto();
                    break;
            }
        }

        public void OpcaoSelecionadaMenuInicial(){
            switch (opcaoSelecionada())
            {
                case 1:
                    Console.Write("Digite para que seguimento deseja" +
                                    " cadastrar a loja:");
                    ApresentarSegmento();
                    CadastrarLoja();
                    break;
                    
                case 2:
                    Console.Write("Digite para que seguimento deseja" +
                                    " cadastrar o produto:");
                    ApresentarSegmento();
                    CadastrarProduto();
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