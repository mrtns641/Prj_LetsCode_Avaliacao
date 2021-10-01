using System;
using System.Collections.Generic;

namespace Prj_LetsCode_Avaliacao
{

    //classe onde as listas de lojas ficarão armazenadas
    public class Shopping
    {
        private List<FastFood> fastFoods = new List<FastFood>();
        private List<SelfService> selfServices = new List<SelfService>();
        private List<LojaPassagens> lojasPassagens = new List<LojaPassagens>();

        private List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Clientes{
            get{return clientes;}
        }

        private List<Passageiros> passageiros = new List<Passageiros>();

        public List<Passageiros> Passageiros{
            get{return passageiros;}
        }
        
         public Passageiros RecebePassageiro()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Passaporte: ");
            string passaporte=Console.ReadLine();
            Passageiros auxiliar = new Passageiros(nome, cpf, passaporte);
            return auxiliar;
        }


        public void AddPassageiro()
        {
            passageiros.Add(RecebePassageiro());
        }

         public Cliente RecebeCliente()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Cliente auxiliar = new Cliente(nome, cpf);
            return auxiliar;
        }


        public void AddCliente()
        {
            clientes.Add(RecebeCliente());
        }

        public List<FastFood> FastFoods{
            get{return fastFoods;}
        }

        public List<SelfService> SelfServices{
            get{return selfServices;}
        }

        public List<LojaPassagens> LojasPassagens{
            get{return lojasPassagens;}
        }

        //adiciona um fast food na lista de fast foods
        public void AddFastFood(FastFood fastFood){
            fastFoods.Add(fastFood);
        }

        /*adiciona um restaurante self service na lista de 
        restaurantes self services */
        public void AddSelfService(SelfService selfService){
            selfServices.Add(selfService);
        }

        /*adiciona uma loja de passagens na lista de 
        lojas de passagens */
        public void AddLojaPassagens(LojaPassagens lojaPassagens){
            lojasPassagens.Add(lojaPassagens);
        }

        public void ListarFastFoods(){

            Console.WriteLine("FastFoods cadastrados:");

            foreach (Loja loja in fastFoods)
            {
                Console.WriteLine(loja.Nome);
            }

            Console.WriteLine("");
        }

        public void ListarSelfServices(){

            Console.WriteLine("Self Services cadastrados:");

            foreach (Loja loja in selfServices)
            {
                Console.WriteLine(loja.Nome);
            }

            Console.WriteLine("");
        }

        public void ListarLojasDePassagens(){

            Console.WriteLine("Lojas de passagens cadastradas:");

            foreach (Loja loja in lojasPassagens)
            {
                Console.WriteLine(loja.Nome);
            }

            Console.WriteLine("");
        }

        public void ListarPassageiros(){

            Console.WriteLine("Passageiros cadastrados:");

            foreach (Passageiros passageiro in passageiros)
            {
                Console.WriteLine(passageiro.Nome);
            }

            Console.WriteLine("");
        }

    }
}