using System;
using System.Collections.Generic;
using DIO_Bank_POO.Funcoes;

namespace bank
{
  public class Menu
  {
    static List<Conta> listContas = new List<Conta>();
    
    public static void principal()
    {
      Funcoes Conta = new Funcoes();
      
      string opcaoUsuario = obterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            Conta.ListarContas();
            break;
          case "2":
            Conta.InserirConta();
            break;
          case "3":
            Conta.Transferir();
            break;
          case "4":
            Conta.Sacar();
            break;
          case "5":
            Conta.Depositar();
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