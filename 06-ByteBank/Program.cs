using ByteBank;
using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "334.344.343-90";
            cliente.Profissao = "Desenvolvedor";

            conta.Titular = cliente;
            conta.Saldo = -10;
            conta.Agencia = 123;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Agencia);

            Console.ReadLine();
        }
    }
}

