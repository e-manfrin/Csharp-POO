using System;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Valor Default valor padrão quando não atribui valor ao campo
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";

            Console.WriteLine("Titular: " + conta.titular);
            Console.WriteLine("Agência: " + conta.agencia);
            Console.WriteLine("Saldo: " + conta.saldo);

            Console.ReadLine();
        }
    }
}
