using System;

namespace bank
{
  public class Menu
  {

    public static void principal()
    {
      string opcaoUsuario = obterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            //ListarContas();
            break;
          case "2":
            //InserirConta();
            break;
          case "3":
            //Transferir();
            break;
          case "4":
            //Sacar();
            break;
          case "5":
            //Depositar();
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
