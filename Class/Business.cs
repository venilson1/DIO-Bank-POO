using System;

namespace bank
{
  public class Business : Ibusiness
  {
    private TipoConta TipoConta { get; set; }
    private double Saldo { get; set; }
    private double Credito { get; set; }
    private string Nome { get; set; }

    public void Conta(TipoConta _tipoConta, double _saldo, double _credito, string _nome)
    {
      this.TipoConta = _tipoConta;
      this.Saldo = _saldo;
      this.Credito = _credito;
      this.Nome = _nome;
    }

    public void Depositar(double valorDeposito)
    {
      this.Saldo = this.Saldo + valorDeposito;
      Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");
    }

    public bool Sacar(double valorSaque)
    {
      //validação saldo insuficiente
      if (this.Saldo - valorSaque < (this.Credito * -1))
      {
        Console.WriteLine("Saldo Insuficiente");
        return false;
      }

      this.Saldo = this.Saldo - valorSaque;

      Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");

      return true;
    }

    public void Transferir(double valorTransferencia, Business contaDestino)
    {
      throw new System.NotImplementedException();
    }
  }
}