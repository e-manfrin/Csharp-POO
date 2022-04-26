using System;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            
            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(resultadoSaque);

            //contaDoBruno.Sacar(50);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            contaDoBruno.Transferir(200, contaDaGabriela);

            //bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);
            //Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
