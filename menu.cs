using System;
using System.Linq;

namespace Prj_LetsCode_Avaliacao
{
  public class Menu
  {
    Shopping shopping = new Shopping();

    /* método que é executado como confirmação de que a ação desejada 
    pelo usuario foi executada com sucesso*/
    public void AcaoConcluida()
    {
      Console.WriteLine("\nAção concluída com êxito!\n");
    }

    // método apresenta o menu inicial 
    public void MenuInicial()
    {
      Console.WriteLine("Favor selecionar uma opção para gerenciar ou simular:");
      Console.WriteLine("1 - Gerenciar lojas");
      Console.WriteLine("2 - Gerenciar clientes");
      Console.WriteLine("0 - Sair");
      OpcaoSelecionadaMenuInicial();
    }

    /* método que de acordo com  a opção selecionada pelo usuário
    no menu inicial leva a outro método*/
    private void OpcaoSelecionadaMenuInicial()
    {
      switch (opcaoSelecionada())
      {
        case 1:
          MenuSegmento();
          break;
        case 2:
          MenuGerenciarClientes();
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

    // método que retorna a opção que o usuário digitou 
    private int opcaoSelecionada()
    {
      Console.Write("Digite o número da opção selecionada: ");
      int opcao = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("");
      return opcao;
    }

    // menu que apresenta os segmentos dos tipos de lojas
    public void MenuSegmento()
    {
      Console.WriteLine("Selecione uma opção de segmento abaixo: ");
      Console.WriteLine("1 - Fast Food");
      Console.WriteLine("2 - Self Service");
      Console.WriteLine("3 - Loja de passagens");
      Console.WriteLine("0 - Voltar");
      OpcaoSelecionadaMenuSegmento();
    }

    /* método que de acordo com  a opção selecionada pelo usuário
    leva a outro método*/
    private void OpcaoSelecionadaMenuSegmento()
    {
      switch (opcaoSelecionada())
      {
        case 1:
          MenuFastFood();
          break;
        case 2:
          MenuSelfService();
          break;
        case 3:
          MenuLojaPassagem();
          break;
        case 0:
          MenuInicial();
          break;
        default:
          Console.WriteLine("Opção inválida! Tente novamente.");
          MenuSegmento();
          break;
      }
    }


    //menus tem que mostrar mensagem da opção a ser selecionada
    private void MenuFastFood()
    {
      Console.WriteLine("Selecione uma opção abaixo:");
      Console.WriteLine("1 - Cadastrar loja de fast food");
      Console.WriteLine("2 - Cadastrar produto");
      Console.WriteLine("3 - Simular Venda");
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
        case 3:
          SimularVendaFastFood();
          break;
        case 0:
          MenuSegmento();
          break;
        default:
          Console.WriteLine("Opção inválida! Tente novamente.");
          MenuFastFood();
          break;
      }
    }

    // método que cadastra FastFoods
    private void CadastrarFastFood()
    {
      Console.WriteLine("Nome do FastFood:");
      FastFood fastFood = new FastFood(Console.ReadLine());
      shopping.AddFastFood(fastFood);
      AcaoConcluida();
      MenuFastFood();
    }


    private void CadastrarProdutoFastFood()
    {
      if (shopping.FastFoods.Count == 0)
      {
        Console.WriteLine("É necessário antes cadastrar alguma loja de fast food para prosseguir com o cadastro do produto!\n");
        MenuFastFood();
      }

      shopping.ListarFastFoods();
      Console.Write("Digite o nome do FastFood que deseja " +
      "cadastrar o produto: ");
      string NomeLojaReceberaProduto = Console.ReadLine();
      bool lojaExiste = false;
      foreach (var item in shopping.FastFoods)
      {
        if (item.Nome == NomeLojaReceberaProduto)
        {
          lojaExiste = true;
          item.AddProduto();
          Console.WriteLine("Listando:");
          item.ListarProdutos();
        }
      }

      if (lojaExiste)
      {
        AcaoConcluida();
        MenuFastFood();
      }
      else
      {
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


      private void SimularVendaFastFood()
      {
        if (shopping.FastFoods.Count == 0)
        {
          Console.WriteLine("É necessário antes cadastrar alguma loja de fast food para prosseguir e simular uma venda!\n");
          MenuFastFood();
        }

         if (shopping.Clientes.Count == 0)
        {
          Console.WriteLine("É necessário antes cadastrar algum cliente para simular uma venda!\n");
          MenuCliente();
        }

        foreach (var item in shopping.FastFoods)
        {
           if (item.Produtos.Count == 0)
            {
            Console.WriteLine("É necessário antes cadastrar algum produto em alguma loja de fast food para simular uma venda!\n");
            MenuFastFood();
            }
        }

        shopping.ListarFastFoods();
        Console.Write("Digite o nome do FastFood que deseja " +
        "simular venda: ");
        string NomeLojaSimularVenda = Console.ReadLine();
        bool lojaExiste = false;
        FastFood auxFastFood = new FastFood(""); 
        foreach (var item in shopping.FastFoods)
        {
          if (item.Nome == NomeLojaSimularVenda)
          {
            lojaExiste = true;
            auxFastFood = item;
          }
        }
       
        if (!lojaExiste)
        {
          Console.WriteLine("Loja não encontrada, " +
          "tente novamente");
          SimularVendaFastFood();
        }

        auxFastFood.ListarProdutos();
        Console.Write("Digite o nome do produto que deseja " +
        "simular venda: ");
        string NomeProdutoSimularVenda = Console.ReadLine();
        bool produtoExiste = false;
        Produto auxProduto = new Produto("",0); 
        foreach (var item in auxFastFood.Produtos)
        {
          if (item.Nome == NomeProdutoSimularVenda)
          {
            produtoExiste = true;
            auxProduto = item;
          }
        }
       
        if (!produtoExiste)
        {
          Console.WriteLine("Produto não encontrado, " +
          "tente novamente");
          SimularVendaFastFood();
        }

        shopping.ListarClientes();
        Console.Write("Digite o nome do cliente que se deseja " +
        "simular venda: ");
        string NomeClienteSimularVenda = Console.ReadLine();
        bool clienteExiste = false;
        Cliente auxCliente = new Cliente("",""); 
        foreach (var item in shopping.Clientes)
        {
          if (item.Nome == NomeClienteSimularVenda)
          {
            clienteExiste = true;
            auxCliente = item;
          }
        }
       
        if (!clienteExiste)
        {
          Console.WriteLine("Cliente não encontrado, " +
          "tente novamente");
          SimularVendaFastFood();
        }

        auxFastFood.Vender(auxCliente, auxProduto);
        AcaoConcluida();
        MenuFastFood();
      
      }

    
    private void MenuSelfService()
    {
      Console.WriteLine("Selecione uma opção abaixo:");
      Console.WriteLine("1 - Cadastrar loja de Self Service");
      Console.WriteLine("2 - Cadastrar produto");
      Console.WriteLine("3 - Simular Venda");
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
        case 3:
          SimularVendaSelfService();
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

    // método que cadastra um SelService
    private void CadastrarSelfService()
    {
      Console.WriteLine("Nome do Self Service:");
      SelfService selfService = new SelfService(Console.ReadLine());
      shopping.AddSelfService(selfService);
      AcaoConcluida();
      MenuSelfService();
    }

    private void CadastrarProdutoSelfService()
    {
      if (shopping.SelfServices.Count == 0)
      {
        Console.WriteLine("É necessário antes cadastrar alguma loja de self service para prosseguir com o cadastro do produto!\n");
        MenuSelfService();
      }

      shopping.ListarSelfServices();
      Console.Write("Digite o nome do Self Service que deseja " +
      "cadastrar o produto: ");
      string NomeLojaReceberaProduto = Console.ReadLine();
      bool lojaExiste = false;
      foreach (var item in shopping.SelfServices)
      {
        if (item.Nome == NomeLojaReceberaProduto)
        {
          lojaExiste = true;
          item.AddProduto();
          Console.WriteLine("Listando:");
          item.ListarProdutos();
        }
      }

      if (lojaExiste)
      {
        AcaoConcluida();
        MenuSelfService();
      }
      else
      {
        Console.WriteLine("Loja não encontrada, " +
        "tente novamente");
        CadastrarProdutoSelfService();
      }
    }

    private void SimularVendaSelfService()
    {
        if (shopping.Clientes.Count == 0)
        {
          Console.WriteLine("É necessário antes cadastrar algum cliente para simular uma venda!\n");
          MenuCliente();
        }

        if (shopping.SelfServices.Count == 0)
        {
          Console.WriteLine("É necessário antes cadastrar alguma loja de self service para prosseguir e simular uma venda!\n");
          MenuSelfService();
        }


        foreach (var item in shopping.SelfServices)
        {
           if (item.Produtos.Count == 0)
            {
            Console.WriteLine("É necessário antes cadastrar algum produto em alguma loja de self service para simular uma venda!\n");
            MenuSelfService();
            }
        }

        shopping.ListarSelfServices();
        Console.Write("Digite o nome do SelfService que deseja " +
        "simular venda: ");
        string NomeLojaSimularVenda = Console.ReadLine();
        bool lojaExiste = false;
        SelfService auxSelfService = new SelfService(""); 
        foreach (var item in shopping.SelfServices)
        {
          if (item.Nome == NomeLojaSimularVenda)
          {
            lojaExiste = true;
            auxSelfService = item;
          }
        }
       
        if (!lojaExiste)
        {
          Console.WriteLine("Loja não encontrada, " +
          "tente novamente");
          SimularVendaSelfService();
        }

        auxSelfService.ListarProdutos();
        Console.Write("Digite o nome do produto que deseja " +
        "simular venda: ");
        string NomeProdutoSimularVenda = Console.ReadLine();
        bool produtoExiste = false;
        Produto auxProduto = new Produto("",0); 
        foreach (var item in auxSelfService.Produtos)
        {
          if (item.Nome == NomeProdutoSimularVenda)
          {
            produtoExiste = true;
            auxProduto = item;
          }
        }
       
        if (!produtoExiste)
        {
          Console.WriteLine("Produto não encontrado, " +
          "tente novamente");
          SimularVendaSelfService();
        }

        shopping.ListarClientes();
        Console.Write("Digite o nome do cliente que se deseja " +
        "simular venda: ");
        string NomeClienteSimularVenda = Console.ReadLine();
        bool clienteExiste = false;
        Cliente auxCliente = new Cliente("",""); 
        foreach (var item in shopping.Clientes)
        {
          if (item.Nome == NomeClienteSimularVenda)
          {
            clienteExiste = true;
            auxCliente = item;
          }
        }
       
        if (!clienteExiste)
        {
          Console.WriteLine("Cliente não encontrado, " +
          "tente novamente");
          SimularVendaSelfService();
        }

        auxSelfService.Vender(auxCliente, auxProduto);
        AcaoConcluida();
        MenuSelfService();
    }

    private void MenuLojaPassagem()
    {
      Console.WriteLine("Selecione uma opção abaixo:");
      Console.WriteLine("1 - Cadastrar loja de Loja de passagens");
      Console.WriteLine("2 - Cadastrar aeronave");
      Console.WriteLine("3 - Simular Venda de Passagem");
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
          CadastrarAeronave();
          break;
        case 3:
          SimularVendaPassagem();
          break;
        case 0: 
          MenuSegmento();
          break;
        default:
          Console.WriteLine("Opção inválida! Tente novamente.");
          MenuLojaPassagem();
          break;
      }
    }

    // método que cadastra uma loja de passagens
    private void CadastrarLojaPassagem()
    {
      Console.WriteLine("Nome da loja de passagens:");
      LojaPassagens lojaPassagens = new LojaPassagens(Console.ReadLine());
      shopping.AddLojaPassagens(lojaPassagens);
      AcaoConcluida();
      MenuLojaPassagem();
    }

    private void CadastrarAeronave()
    {
      if (shopping.LojasPassagens.Count == 0)
      {
        Console.WriteLine("É necessário antes cadastrar alguma loja de passagens para prosseguir com o cadastro da aeronave!\n");
        MenuLojaPassagem();
      }

      shopping.ListarLojasDePassagens();
      Console.Write("Digite o nome da loja de passagens que deseja " +
      "cadastrar a aeronave: ");
      string NomeLojaReceberaAeronave = Console.ReadLine();
      bool lojaExiste = false;
      foreach (var item in shopping.LojasPassagens)
      {
        if (item.Nome == NomeLojaReceberaAeronave)
        {
          lojaExiste = true;
          item.AddAeronave();

          // Console.WriteLine("Cadastrando:");
          // item.ListarProdutos();
        }
      }

      if (lojaExiste)
      {
        AcaoConcluida();
        MenuLojaPassagem();
      }
      else
      {
        Console.WriteLine("Loja não encontrada, " +
        "tente novamente");
        CadastrarAeronave();
      }
    }

    private void SimularVendaPassagem()
    {
      
        if (shopping.Passageiros.Count == 0)
        {
          Console.WriteLine("É necessário antes cadastrar algum passageiro para simular uma venda de passagem!\n");
          MenuPassageiro();
        }

        if (shopping.LojasPassagens.Count == 0)
        {
          Console.WriteLine("É necessário antes cadastrar alguma loja de passagem para prosseguir e simular uma venda de passagem!\n");
          MenuSelfService();
        }

        foreach (var item in shopping.LojasPassagens)
        {
           if (item.Aeronaves.Count == 0)
            {
            Console.WriteLine("É necessário antes cadastrar alguma aeronave em alguma loja de passagens para simular uma venda de passagem!\n");
            MenuLojaPassagem();
            }
        }

        shopping.ListarLojasDePassagens();
        Console.Write("Digite o nome da loja de passagens que deseja " +
        "simular venda: ");
        string NomeLojaSimularVenda = Console.ReadLine();
        bool lojaExiste = false;
        LojaPassagens auxLojaPassagens = new LojaPassagens(""); 
        foreach (var item in shopping.LojasPassagens)
        {
          if (item.Nome == NomeLojaSimularVenda)
          {
            lojaExiste = true;
            auxLojaPassagens = item;
          }
        }
       
        if (!lojaExiste)
        {
          Console.WriteLine("Loja não encontrada, " +
          "tente novamente");
          SimularVendaPassagem();
        }

        auxLojaPassagens.ListarAeronaves();
        Console.Write("Digite o nome da aeronave que deseja " +
        "voar: ");
        string ModeloAeronaveSimularVenda = Console.ReadLine();
        bool aeronaveExiste = false;
        Aeronave auxAeronave = new Aeronave("",""); 
        foreach (var item in auxLojaPassagens.Aeronaves)
        {
          if (item.Modelo == ModeloAeronaveSimularVenda)
          {
            aeronaveExiste = true;
            auxAeronave = item;
          }
        }
       
        if (!aeronaveExiste)
        {
          Console.WriteLine("Aeronave não encontrada, " +
          "tente novamente");
          SimularVendaPassagem();
        }

        shopping.ListarPassageiros();
        Console.Write("Digite o nome do passageiro que se deseja " +
        "incluir na passagem: ");
        string NomePassageiroSimularVenda = Console.ReadLine();
        bool passageiroExiste = false;
        Passageiros auxPassageiro = new Passageiros("","",""); 
        foreach (var item in shopping.Passageiros)
        {
          if (item.Nome == NomePassageiroSimularVenda)
          {
            passageiroExiste = true;
            auxPassageiro = item;
          }
        }
       
        if (!passageiroExiste)
        {
          Console.WriteLine("Passageiro não encontrado, " +
          "tente novamente");
          SimularVendaPassagem();
        }
        
        Console.Write("Digite o número do assento: ");
        int assento;
        Int32.TryParse(Console.ReadLine(), out assento);
    
        Console.Write("Digite o destino do voo: ");
        string destino = Console.ReadLine();
      
        Console.Write("Digite o valor da passagem: ");
        double valor;
        Double.TryParse(Console.ReadLine(), out valor);

        Passagem passagem = new Passagem(auxPassageiro, auxAeronave, assento, destino, valor);
        auxLojaPassagens.VenderPassagem(passagem);
        AcaoConcluida();
        MenuLojaPassagem();
    }

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

    // método que cadastra um Cliente
    private void CadastrarCliente()
    {
      shopping.AddCliente();
      AcaoConcluida();
      MenuGerenciarClientes();
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

    // método que cadastra um Passageiro
    private void CadastrarPassageiro()
    {
      shopping.AddPassageiro();
      AcaoConcluida();
      MenuPassageiro();
    }

    private void RegistrarBagagem() 
    { 
      if (shopping.Passageiros.Count == 0)
      {
        Console.WriteLine("É necessário antes cadastrar algum passageiro para prosseguir com o registro de bagagem!\n");
        MenuPassageiro();
      }

      shopping.ListarPassageiros();
      Console.Write("Digite o nome do passageiro " +
      "que se deseja registrar bagagem: ");
      string NomePassageiroRegistraBagagem = Console.ReadLine();
      bool passageiroExiste = false;
      foreach (var item in shopping.Passageiros)
      {
        if (item.Nome == NomePassageiroRegistraBagagem)
        {
          passageiroExiste = true;
          item.AddBagagem();

          // Console.WriteLine("Cadastrando:");
          // item.ListarProdutos();
        }

        if (passageiroExiste)
        {
          AcaoConcluida();
          MenuPassageiro();
        }
        else
        {
        Console.WriteLine("Passageiro não encontrado, " +
        "tente novamente");
        RegistrarBagagem();
        }
    }

    }
  }
}