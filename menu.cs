using System;
using System.Linq;

namespace Prj_LetsCode_Avaliacao
{
    public class Menu
    {
        Shopping shopping = new Shopping();

        public void AcaoConcluida(){
            Console.WriteLine("Ação foi concluida com exito!\n");
        }

        public void MenuInicial()
        {
            Console.WriteLine("Favor selecionar uma opção para gerenciar ou simular:");
            Console.WriteLine("1 - Gerenciar lojas");
            Console.WriteLine("2 - Gerenciar clientes");
            Console.WriteLine("3 - Simular venda");
            Console.WriteLine("0 - Sair");
            OpcaoSelecionadaMenuInicial();
        }

        private void OpcaoSelecionadaMenuInicial(){
            switch (opcaoSelecionada())
            {
                case 1:
                    MenuSegmento();
                    break;
                case 2:
                    MenuGerenciarClientes();
                    break;
                case 3:
                    Console.Write("");
                    break;
                case 0:
                    Console.WriteLine("Agradecemos pela visita! Volte sempre!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    MenuInicial();
                    break;
            }
        } 
        
        private int opcaoSelecionada(){
            Console.Write("Digite o número da opção selecionada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return opcao;
        }

        public void MenuSegmento()
        {
            Console.WriteLine("Selecione uma opção de segmento abaixo: ");
            Console.WriteLine("1 - Fast Food");
            Console.WriteLine("2 - Self Service");
            Console.WriteLine("3 - Loja de passagens");
            Console.WriteLine("0 - Voltar");
            OpcaoSelecionadaMenuSegmento();
        }

        private void OpcaoSelecionadaMenuSegmento()
        {
            switch (opcaoSelecionada())
            {
                case 1: //cadastrar produto fast food
                    MenuFastFood();
                    break;
                case 2: //cadastrar produto self service
                    MenuSelfService();
                    break;
                case 3: //cadastrar passagem ou cadastrar aeronave
                    MenuLojaPassagem();
                    break;
                case 0: //voltar
                    MenuInicial();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    MenuSegmento();
                    break;
            }
        }


        //menus tem que mostrar mensagem da opção a ser selecionada

        private void MenuFastFood(){
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.WriteLine("1 - Cadastrar loja de fast food");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("0 - Voltar");
            OpcaoSelecionadaMenuFastFood();
        }

        private void OpcaoSelecionadaMenuFastFood()
        {
            switch (opcaoSelecionada())
            {
                case 1: 
                    CadastrarFastFood();
                    break;
                case 2: 
                    CadastrarProdutoFastFood();
                    break;
                case 0: //voltar
                    MenuSegmento();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    MenuFastFood();
                    break;
            }
        }

        private void CadastrarFastFood(){
            Console.WriteLine("Nome do FastFood:");
            FastFood fastFood = new FastFood(Console.ReadLine());
            shopping.AddFastFood(fastFood);
            AcaoConcluida();
            MenuFastFood();
        }

        private void CadastrarProdutoFastFood(){
            shopping.ListarFastFoods();
            Console.Write("Digite o nome do FastFood que deseja " +
            "cadastrar o produto: ");
            string NomeLojaReceberaProduto = Console.ReadLine();
            bool lojaExiste = false;
            foreach (var item in shopping.FastFoods)
            {
                if(item.Nome == NomeLojaReceberaProduto){
                    lojaExiste = true;
                    item.AddProduto();
                    Console.WriteLine("Listando:");
                    item.ListarProdutos();
                } 
            }
            
            if(lojaExiste) {
                AcaoConcluida();
                MenuFastFood();
            } else {
                Console.WriteLine("Loja não encontrada, " +
                "tente novamente");
                CadastrarProdutoFastFood();
            }

            /*não usamos o linq pq do jeito apresentado abaixo não 
            tem tratamento de erro; ou seja, se o usuário digitar 
            uma loja inexistente sobe um erro na cara dele. Visto isso
            optamos pelo foreach tradicional com um 'tratamento de 
            erro' caso o usuário digite o nome de uma loja 
            inexistente*/

            /*(from fastFood in shopping.FastFoods where 
            fastFood.Nome == NomeLojaReceberaProduto select 
            fastFood).FirstOrDefault().AddProduto();*/                  
        }


        private void MenuSelfService()
        {
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.WriteLine("1 - Cadastrar loja de Self Service");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("0 - Voltar");
            OpcaoSelecionadaMenuSelfService();
        }

        private void OpcaoSelecionadaMenuSelfService()
        {
            switch (opcaoSelecionada())
            {
                case 1: 
                    CadastrarSelfService();
                    break;
                case 2: 
                    CadastrarProdutoSelfService();
                    break;
                case 0: //voltar
                    MenuSegmento();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    MenuSelfService();
                    break;
            }
        }

        private void CadastrarSelfService(){}

        private void CadastrarProdutoSelfService(){}





        private void MenuLojaPassagem()
        {
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.WriteLine("1 - Cadastrar loja de Loja de passagens");
            Console.WriteLine("2 - Cadastrar passagem");
            Console.WriteLine("3 - Cadastrar aeronave");
            Console.WriteLine("0 - Voltar");
            OpcaoSelecionadaMenuLojaPassagem();
        }

        private void OpcaoSelecionadaMenuLojaPassagem()
        {
            switch (opcaoSelecionada())
            {
                case 1: 
                    CadastrarLojaPassagem();
                    break;
                case 2: 
                    CadastrarPassagem();
                    break;
                case 3:
                    CadastrarAeronave();
                    break;
                case 0: //voltar
                    MenuSegmento();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    MenuLojaPassagem();
                    break;
            }
        }

        private void CadastrarLojaPassagem(){}

        private void CadastrarPassagem(){}

        private void CadastrarAeronave(){}
        

        private void MenuGerenciarClientes()
        {
            Console.WriteLine("Selecione um tipo de cliente:");
            Console.WriteLine("1 - Cliente comum");
            Console.WriteLine("2 - Passageiros");
            Console.WriteLine("0 - Voltar");
            OpcaoSelecionadaMenuGerenciarClientes();
        }

        private void OpcaoSelecionadaMenuGerenciarClientes()
        {
            switch (opcaoSelecionada())
            {
                case 1:
                    MenuCliente();
                    break;
                case 2:
                    MenuPassageiro();
                    break;
                case 0:
                    MenuInicial();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    MenuGerenciarClientes();
                    break;
            }
        }

        private void MenuCliente()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("0 - Voltar");
            OpcaoSelecionadaMenuCliente();
        }

        private void OpcaoSelecionadaMenuCliente()
        {
            switch (opcaoSelecionada())
            {
                case 1:
                    CadastrarCliente();
                    break;
                case 0:
                    MenuGerenciarClientes();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    MenuCliente();
                    break;
            }
        }

        private void CadastrarCliente(){

        }


        private void MenuPassageiro()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Cadastrar Passageiro");
            Console.WriteLine("2 - Registrar bagagem");
            Console.WriteLine("0 - Voltar");
            OpcaoSelecionadaMenuPassageiro();
        }

        private void OpcaoSelecionadaMenuPassageiro()
        {
            switch (opcaoSelecionada())
            {
                case 1:
                    CadastrarPassageiro();
                    break;
                case 2:
                    RegistrarBagagem();
                    break;
                case 0:
                    MenuGerenciarClientes();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    MenuPassageiro();
                    break;
            }
        }

        private void CadastrarPassageiro(){}

        private void RegistrarBagagem(){}



    }
}
