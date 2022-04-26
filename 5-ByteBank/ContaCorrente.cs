//Não é nescessário utilizar o Using
//using _5_ByteBank;

namespace ByteBank
{
    //Temos uma classe ContaCorrente para criar o nosso objeto no Program
    //Classe é a especificação
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        //Função sempre com letra maíscula
        //Função e método são termos sinônimos,
        //mas, é comum encontrarmos o termo função quando há retorno e método quando não há.
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

