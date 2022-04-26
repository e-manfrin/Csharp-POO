using _07_ByteBank;
using ByteBank;
using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //O set está como private
            //ContaCorrente.TotalDeContasCriadas = 90;

            ContaCorrente conta = new ContaCorrente(232323,86);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente contaDaGabriela = new ContaCorrente(3223, 23);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //Regra de negócio não permite
            //conta.Agencia = -10;

            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);

            Console.ReadLine();
        }
    }
}

