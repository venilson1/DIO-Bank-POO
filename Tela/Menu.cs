using System;
using System.Collections.Generic;

namespace bank
{
  public class Menu
  {
    static List<Conta> listContas = new List<Conta>();
    public static void principal()
    {
      string opcaoUsuario = obterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            ListarContas();
            break;
          case "2":
            InserirConta();
            break;
          case "3":
            Transferir();
            break;
          case "4":
            Sacar();
            break;
          case "5":
            Depositar();
            break;
          case "C":
            Console.Clear();
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }

        opcaoUsuario = obterOpcaoUsuario();
      }

      Console.WriteLine("Obrigado por utilizar nossos serviços");
      Console.ReadLine();
    }

    private static void Transferir()
    {
      Console.WriteLine("Digite o numero da conta Origem:");
      int indiceContaOrigem = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o numero da conta Destino:");
      int indiceContaDestino = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor a ser transferido:");
      double valorTransferencia = int.Parse(Console.ReadLine());

      listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
    }

    private static void Depositar()
    {
      Console.WriteLine("Digite o numero da conta:");
      int indiceConta = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor a ser depositado:");
      int valorDeposito = int.Parse(Console.ReadLine());

      listContas[indiceConta].Depositar(valorDeposito);
    }

    private static void Sacar()
    {
      Console.WriteLine("Digite o número da conta");
      int indiceconta = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor a ser sacado");
      double valorSaque = double.Parse(Console.ReadLine());

      listContas[indiceconta].Sacar(valorSaque);
    }

    private static void ListarContas()
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

    private static void InserirConta()
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

    private static string obterOpcaoUsuario()
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