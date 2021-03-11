namespace bank
{
  public class Conta : Business
  {
    public Conta(
      TipoConta tipoConta,
      double saldo,
      double credito,
      string nome
      )
    {
      this.TipoConta = tipoConta;
      this.Saldo = saldo;
      this.Credito = credito;
      this.Nome = nome;
    }
  }
}