using System;

namespace Prj_LetsCode_Avaliacao
{
  public class Passagem
  {

    private int assento;
    
    private double valor;
    public double Valor
    {
      get { return valor; }
      set { valor = value; }
    }

    private string destino;
    public string Destino
    {
      get { return destino; }
      set { destino = value; }
    }

    private Passageiros passageiro;
    public Passageiros Passageiro
    {
      get { return passageiro; }
      set { passageiro = value; }
    }

    private Aeronave aeronave;
    public Aeronave Aeronave
    {
      get { return aeronave; }
      set { aeronave = value; }
    }

    public int Assento
    {
      get { return assento; }
      set { assento = value; }
    }

    // Construtor da Classe Passagem
    public Passagem(Passageiros Passageiro, Aeronave Aeronave, int assento, string destino, double valor)
    {
      this.aeronave = Aeronave;
      this.passageiro = Passageiro;
      this.Assento = assento;
      this.Destino = destino;
      this.Valor = valor;
    }
  }
}