namespace bank
{
  public interface Ibusiness
  {
    void Conta(
      TipoConta tipoConta,
      double saldo,
      double credito,
      string nome
    );

    bool Sacar(double valorSaque);

    void Depositar(double valorDeposito);

    void Transferir(double valorTransferencia, Business contaDestino);
  }
}