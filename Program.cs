using System;

namespace bank
{
    class Program 
    {
        static void Main(string[] args)
        {
           Conta c1 = new Conta(TipoConta.PessoaFisica, 500, 500, "Venilson"); 
           c1.Sacar(1001);
           Console.WriteLine(c1.ToString());
           Console.ReadLine();
        }
    }
}
