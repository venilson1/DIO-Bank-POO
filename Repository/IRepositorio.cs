using System.Collections.Generic;

namespace DIO_Bank_POO.Repository
{
  public interface IRepositorio<T>
  {
    void Transferir();
    void Depositar();
    void Sacar();
    void ListarContas();
    void InserirConta();
  }
}