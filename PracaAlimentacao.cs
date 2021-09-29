using System;

namespace Prj_LetsCode_Avaliacao
{
    public class PracaAlimentacao
    {

        private Cliente cliente;

        public void Menu(){
            CadastroCliente();
            Console.WriteLine($"\n{cliente.Nome}, em qual tipo de restaurante você deseja comer agora?");
            SelecionaTipoRestaurante();
        }


        public void CadastroCliente()
        {
            Console.WriteLine("Antes de prosseguir para matar a fome, vamos precisar de algumas informações, ok?");
            Console.Write("Qual o seu nome? Digite aqui: ");
            string NomeCliente = Console.ReadLine();
            Console.Write("E qual o seu CPF? Digite aqui: ");
            string CpfCliente = Console.ReadLine();
            Cliente auxiliar = new Cliente(NomeCliente, CpfCliente);
            this.cliente = auxiliar;
        }

        public void SelecionaTipoRestaurante()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Fast Food");
            Console.WriteLine("2 - Self-service");
            Console.WriteLine("0 - Sair do Zerg");
            Console.Write("Digite o número da opção selecionada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (opcao)
            {
                case 1:
                    SelecionaFastFood();
                    break;
                case 2:
                    SelecionaSelfService();
                    break;
                case 0:
                    Console.WriteLine("Agradecemos pela visita! Volte sempre!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida! Favor tentar novamente.");
                    SelecionaTipoRestaurante();
                    break;
            }
        }

        public void SelecionaFastFood()
        {
            string[] Restaurantes = {"McDonalds", "BurgerKing", "Bob's"};

            Console.WriteLine("Escolha um restaurante ou digite '0' para sair:");
            for (int i = 0; i < Restaurantes.Length; i++)
            {
                Console.WriteLine($"{i+1} - {Restaurantes[i]}");
            }
            Console.Write("Digite o número da opção selecionada: ");
            int RestauranteSelecionado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if(RestauranteSelecionado == 0)
            {
                Console.WriteLine("Agradecemos pela visita! Volte sempre!");
                Environment.Exit(0);
            }

            Produto produto1 = new Produto("Burger de carne bovina 180g", 29.99);
            Produto produto2 = new Produto("Burger vegetariano 160g", 22.99);
            Produto produto3 = new Produto("Burger especial carne bovina 180g extra cheddar", 34.99);

            Produto[] Pedidos = {produto1, produto2, produto3};
            Console.WriteLine("Agora selecione qual item deseja pedir ou digite '0' para sair: ");
            for (int i = 0; i < Pedidos.Length; i++)
            {
                Console.WriteLine($"{i+1} - {Pedidos[i].Nome} - R${Pedidos[i].Preco}");
            }
            Console.Write("Digite o número da opção selecionada: ");
            int PedidoSelecionado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if(PedidoSelecionado == 0)
            {
                Console.WriteLine("Agradecemos pela visita! Volte sempre!");
                Environment.Exit(0);
            }

            FastFood loja = new FastFood(Restaurantes[RestauranteSelecionado-1],Pedidos[PedidoSelecionado-1],cliente);
            loja.Vender();

            Console.WriteLine("Você voltou para a escolha do tipo de restaurante.");
            SelecionaTipoRestaurante();
        }

        public void SelecionaSelfService()
        {
            string[] Restaurantes = {"Comida do interior", "Comida de casa", "Comida da fazenda"};

            Console.WriteLine("Escolha um restaurante ou digite '0' para sair:");
            for (int i = 0; i < Restaurantes.Length; i++)
            {
                Console.WriteLine($"{i+1} - {Restaurantes[i]}");
            }
            Console.Write("Digite o número da opção selecionada: ");
            int RestauranteSelecionado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if(RestauranteSelecionado == 0)
            {
                Console.WriteLine("Agradecemos pela visita! Volte sempre!");
                Environment.Exit(0);
            }

            Produto produto1 = new Produto("Feijoada", 29.99);
            Produto produto2 = new Produto("Feijão tropeiro", 22.99);
            Produto produto3 = new Produto("Churrasco", 34.99);

            Produto[] Pedidos = {produto1, produto2, produto3};
            Console.WriteLine("Agora selecione qual item deseja pedir ou digite '0' para sair: ");
            for (int i = 0; i < Pedidos.Length; i++)
            {
                Console.WriteLine($"{i+1} - {Pedidos[i].Nome}");
            }
            Console.Write("Digite o número da opção selecionada: ");
            int PedidoSelecionado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if(PedidoSelecionado == 0)
            {
                Console.WriteLine("Agradecemos pela visita! Volte sempre!");
                Environment.Exit(0);
            }

            SelfService loja = new SelfService(Restaurantes[RestauranteSelecionado-1],Pedidos[PedidoSelecionado-1],cliente);
            loja.Vender();

            Console.WriteLine("Você voltou para a escolha do tipo de restaurante.");
            SelecionaTipoRestaurante();

        }
    }
}