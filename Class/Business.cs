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
      throw new System.NotImplementedException();
    }

    public void Depositar(double valorDeposito)
    {
      throw new System.NotImplementedException();
    }

    public bool Sacar(double valorSaque)
    {
      throw new System.NotImplementedException();
    }

    public void Transferir(double valorTransferencia, Business contaDestino)
    {
      throw new System.NotImplementedException();
    }
  }
}