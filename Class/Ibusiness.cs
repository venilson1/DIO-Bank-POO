namespace bank
{
  public interface Ibusiness
  {
    void Conta(
      TipoConta _tipoConta,
      double _saldo,
      double _credito,
      string _nome
    );

    bool Sacar(double valorSaque);

    void Depositar(double valorDeposito);

    void Transferir(double valorTransferencia, Business contaDestino);
  }
}