using System;

namespace Prj_LetsCode_Avaliacao
{
  public class Guiche : ILoja
  {
    private Passagem passagem;
    private Passageiros passageiro;

    private Aeronave aeronave;
    private Bagagem bagagem;
    
    private string nome;
    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }

    public virtual void Vender()
    {
      
      if(passageiro.Passaporte == "0")
      {
        Console.WriteLine($"Cliente {passageiro.Nome} de CPF '{passageiro.Cpf}', seu voo com destino a {passagem.Destino} será na aeronave {aeronave.Modelo} de identificação '{aeronave.Identificacao}', no valor de R${passagem.Valor}.");
      }else
      {
        Console.WriteLine($"Cliente {passageiro.Nome} de CPF '{passageiro.Cpf}' e passaporte de número '{passageiro.Passaporte}', seu voo com destino a {passagem.Destino} será na aeronave {aeronave.Modelo} de identificação '{aeronave.Identificacao}', no valor de R${passagem.Valor}.");
      }
      

      if(bagagem.Peso!=0)
      {
        Console.WriteLine($"Sua bagagem de {bagagem.Peso}Kg poderá ser despachada no terminal de embarque.");
      } 
      Console.WriteLine($"Venda Finalizada, obrigado por voar {Nome}! Boa Viagem!\n");
    }

    public Guiche(string nome,  Passagem Passagem, Bagagem Bagagem)
    {
      this.nome = nome;
      this.passagem = Passagem;
      this.passageiro = Passagem.Passageiro;
      this.bagagem = Bagagem;
      this.aeronave = Passagem.Aeronave;
    
    }
  }
}