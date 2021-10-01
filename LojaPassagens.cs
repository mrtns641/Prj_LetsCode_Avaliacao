using System;
using System.Collections.Generic;

namespace Prj_LetsCode_Avaliacao
{
    public class LojaPassagens : Loja                               
    {

        protected List<Aeronave> aeronaves = new List<Aeronave>();

        public List<Aeronave> Aeronaves
        {
            get {return aeronaves;}
        }

        public void AddAeronave()
        {
            aeronaves.Add(RecebeAeronave());
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

        public void ListarAeronaves(){

            Console.WriteLine("Aeronaves cadastradas:");

            foreach (Aeronave aeronave in aeronaves)
            {
                Console.WriteLine(aeronave.Modelo);
            }

            Console.WriteLine("");
        }

        public virtual void VenderPassagem(Passagem passagem){
            Console.WriteLine("\n###################################################");
            Console.WriteLine($"Destino: {passagem.Destino}");
            Console.WriteLine($"Nome: {passagem.Passageiro.Nome} CPF: {passagem.Passageiro.Cpf} Passaporte:{passagem.Passageiro.Passaporte}");
            Console.WriteLine($"Aeronave: {passagem.Aeronave.Modelo} - {passagem.Aeronave.Identificacao} Assento: {passagem.Assento}");
            Console.WriteLine($"Total pago: R$ {passagem.Valor}");
            Console.WriteLine($"Agradecemos por voar {Nome}! Boa viagem!");
            Console.WriteLine($"Processo finalizado!");
            Console.WriteLine("###################################################\n");
        }
        
        // Construtor da Classe LojaPassagens.
        public LojaPassagens(string nome) : base(nome){}
    }
}