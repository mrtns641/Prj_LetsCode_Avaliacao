using System;
using System.Collections.Generic;

namespace Prj_LetsCode_Avaliacao
{
    public class LojaPassagens : Loja, ILoja
    {

        protected List<Aeronave> aeronaves = new List<Aeronave>();

        public List<Aeronave> Aeronave
        {
            get {return aeronaves;}
        }


        public Aeronave RecebeAeronave()
        {
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Idenficação: ");
            string identificacao = Console.ReadLine();
            Aeronave auxiliar = new Aeronave(modelo, identificacao);
            return auxiliar;
        }


        public void AddAeronave()
        {
            aeronaves.Add(RecebeAeronave());
        }

        // Método de pesagem do prato.
        public void PesarPrato(){
            Console.WriteLine($"Pesando o prato de .");
        }
        
        // Método de venda.
        public virtual void Vender(Venda venda){
            Console.WriteLine($"Produto - prato de ");
            PesarPrato();
            Console.WriteLine($"Valor total: R$");
            Console.WriteLine($"CPF na nota: ");
            Console.WriteLine($" - Venda concluída! Volte sempre, !\n");
        }
        
        // Construtor da Classe LojaPassagens.
        public LojaPassagens(string nome) : base(nome){}
    }
}