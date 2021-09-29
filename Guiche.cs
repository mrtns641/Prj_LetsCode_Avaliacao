using System;

namespace Prj_LetsCode_Avaliacao
{
  public class Guiche : ILoja
  {
    private Passagem passagem;
    private Passageiros passageiro;
    private Aeronave aeronave;
    private string destino;
    private int assento;

    private double valor;

    public int Assento
    {
      get { return assento; }
      set { assento = value; }
    }
    private Bagagem bagagem;
    private string nome;
    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }

    public virtual void Vender()
    {
      passagem.Assento = assento;
      passagem.Passageiro = passageiro;
      passagem.Aeronave = aeronave;
      passagem.Destino = destino;
      passagem.Valor = valor;

      Console.WriteLine($"{passageiro.Nome}, seu voo com destino a {passagem.Destino}");
      Console.WriteLine($"será na aeronave {aeronave.Modelo} no valor de R$: {passagem.Valor}");
      Console.WriteLine($"Venda Finalizada, obrigado por voar {Nome} !");


    }

    public Guiche(string nome, Passageiros passageiro, Aeronave aeronave, Bagagem bagagem, int assento, double Valor)
    {
      this.passageiro = passageiro;
      this.nome = nome;
      this.aeronave = aeronave;
      this.bagagem = bagagem;
      this.assento = assento;
      this.valor = Valor;
    }
  }
}