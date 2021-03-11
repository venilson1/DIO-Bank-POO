using System;
using System.Collections.Generic;

namespace bank
{
  public class TelaGeral
  {
    static List<Conta> listContas = new List<Conta>();
    protected static void TransferenciaContas()
    {
      Console.WriteLine("Digite o numero da conta Origem:");
      int indiceContaOrigem = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o numero da conta Destino:");
      int indiceContaDestino = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor a ser transferido:");
      double valorTransferencia = int.Parse(Console.ReadLine());

      listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
    }

    protected static void DepositarConta()
    {
      Console.WriteLine("Digite o numero da conta:");
      int indiceConta = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor a ser depositado:");
      int valorDeposito = int.Parse(Console.ReadLine());

      listContas[indiceConta].Depositar(valorDeposito);
    }

    protected static void SacarConta()
    {
      Console.WriteLine("Digite o número da conta");
      int indiceconta = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor a ser sacado");
      double valorSaque = double.Parse(Console.ReadLine());

      listContas[indiceconta].Sacar(valorSaque);
    }

    protected static void ListarContas()
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

    protected static void InserirConta()
    {
      Console.WriteLine("Inserir nova conta: ");

      Console.WriteLine("Digite 1 para cpf ou 2 para cnpj: ");
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

    protected static string obterOpcaoUsuario()
    {
      Console.WriteLine("\n\nDiO Bank a seu dispor!!!");
      Console.WriteLine("Informe a opção desejada");

      Console.WriteLine("1. -  Listar Contas");
      Console.WriteLine("2. - Inserir Nova Conta");
      Console.WriteLine("3. - Transferir");
      Console.WriteLine("4. - Sacar");
      Console.WriteLine("5. - Depositar");
      Console.WriteLine("C - Limpar Tela");
      Console.WriteLine("X - Sair\n");

      String opcaoUsuario = Console.ReadLine().ToUpper();
      return opcaoUsuario;
    }
  }
}