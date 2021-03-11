using System;

namespace bank
{
  public class Business : Ibusiness
  {
    protected TipoConta TipoConta { get; set; }
    protected double Saldo { get; set; }
    protected double Credito { get; set; }
    protected string Nome { get; set; }

    public void Conta(TipoConta tipoConta, double saldo, double credito, string nome)
    {
      this.TipoConta = tipoConta;
      this.Saldo = saldo;
      this.Credito = credito;
      this.Nome = nome;
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
      if (this.Sacar(valorTransferencia))
      {
        contaDestino.Depositar(valorTransferencia);
      }
    }

    public override string ToString()
    {
      string retorno = $"TipoConta {this.TipoConta} | Nome: {this.Nome} | Saldo: {this.Saldo} | Credito: {this.Credito} |";
      return retorno;
    }
  }
}