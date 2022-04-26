using System;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Valor Default valor padrão quando não atribui valor ao campo
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 876;
            contaDaGabriela.numero = 12323;

            ContaCorrente contaDaCosta = new ContaCorrente();
            contaDaCosta.titular = "Gabriela";
            contaDaCosta.agencia = 876;
            contaDaCosta.numero = 12323;

            Console.WriteLine("Igualdade de tipo referência: " + (contaDaGabriela == contaDaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo valor: " + (idade == idadeMaisUmaVez));

            contaDaGabriela = contaDaCosta;
            Console.WriteLine("Duas variáveis que apresentam para o mesmo objeto da memória: " + (contaDaGabriela == contaDaCosta));

            //Ambas variáveis apontam para o mesmo objeto por isso permanece o mesmo valor
            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaCosta.saldo);

            Console.ReadLine();
        }
    }
}
