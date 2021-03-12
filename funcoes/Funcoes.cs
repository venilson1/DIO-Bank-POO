using System;
using System.Collections.Generic;
using bank;
using DIO_Bank_POO.Repository;

namespace DIO_Bank_POO.Funcoes
{
  public class Funcoes : IRepositorio<Conta>
  {
    private List<Conta> listContas = new List<Conta>();

    public void Depositar()
    {
      Console.WriteLine("Digite o numero da conta:");
      int indiceConta = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor a ser depositado:");
      int valorDeposito = int.Parse(Console.ReadLine());

      listContas[indiceConta].Depositar(valorDeposito);
    }

    public void InserirConta()
    {
      Console.WriteLine("Inserir nova conta: ");

      Console.WriteLine("Digite 1 para pesso fisica ou 2 para pessoa juridica: ");
      int entradaTipoConta = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o nome do cliente: ");
      string entradaNome = Console.ReadLine();

      Console.WriteLine("Digite o saldo inicial: ");
      double entradaSaldo = double.Parse(Console.ReadLine());

      Console.WriteLine("Digite  crédito: ");
      double entradaCredito = double.Parse(Console.ReadLine());

      Conta novaConta = new Conta(
        (TipoConta)entradaTipoConta,
        entradaSaldo,
        entradaCredito,
        entradaNome
        );

      listContas.Add(novaConta);
    }

    public void ListarContas()
    {
      Console.WriteLine("listar contas");

      if (listContas.Count == 0)
      {
        Console.WriteLine("\nNenhuma conta cadastrada\n");
        return;
      }

      for (int i = 0; i < listContas.Count; i++)
      {
        Conta conta = listContas[i];
        Console.Write($"\n#.{i}  {conta}");
      }
    }

    public void Sacar()
    {
      Console.WriteLine("Digite o número da conta");
      int indiceconta = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor a ser sacado");
      double valorSaque = double.Parse(Console.ReadLine());

      listContas[indiceconta].Sacar(valorSaque);
    }

    public void Transferir()
    {
      Console.WriteLine("Digite o numero da conta Origem:");
      int indiceContaOrigem = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o numero da conta Destino:");
      int indiceContaDestino = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor a ser transferido:");
      double valorTransferencia = int.Parse(Console.ReadLine());

      listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
    }
  }
}