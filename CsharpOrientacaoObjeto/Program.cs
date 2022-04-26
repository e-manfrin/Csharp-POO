using System;

namespace CsharpOrientacaoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO!");

            //Construção do OBJETO a partir da classe para a criação de um objeto na memória do computador
            //com o new(instanciando)
            //Tipo conta corrente -> ContaCorrente -> variável contaDaGabriela
            
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 123;
            contaDaGabriela.numero = 456;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Número: " + contaDaGabriela.numero);      
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            //contaDaGabriela.saldo = contaDaGabriela.saldo + 200;
            contaDaGabriela.saldo +=  200;
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
