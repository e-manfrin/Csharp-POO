//Não é nescessário utilizar o Using
//using _5_ByteBank;

using _07_ByteBank;

namespace ByteBank
{
    //Temos uma classe ContaCorrente para criar o nosso objeto no Program
    //Classe é a especificação
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        //public Cliente Titular
        //{
        //get
        //{
        //return _titular;
        //}
        //set
        //{
        //_titular = value;
        //}
        //}

        //Informação da classe 
        public static int TotalDeContasCriadas { get; private set; }
        public int _agencia;
           
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set 
            {
                if(value <= 0)
                {
                    return;
                }
                _agencia = value; 
            } 
        }
        public int Numero { get; set; }

        private double _saldo = 100;
        //_ é um campo privado e é um campo que pertence apenas a essa classe

        //O que vem de fora chama-se pela variável value
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        //Todo esse processo é o encapuslamento do saldo protegendo a informação
        //(double saldo) novo saldo que será passado pelo cliente
        //Era DefinirSaldo ->  SetSaldo
        //public void SetSaldo(double saldo)
        //{
            //if(saldo < 0)
            //{
                //Lançar um erro na aplicação por enquanto apenas um return
                //return em um método void significa que para de executar o método
               // return;
            //}
            //else
            //{
                //this.saldo é do atributo
                //this.saldo = saldo;
            //}
        //}

        //Verbo no infinitivo e com letra maiúscula
        //Era ObterSaldo -> GetSaldo
        //public double GetSaldo()
        //{
            //return saldo;
        //}

        //Função sempre com letra maíscula
        //Função e método são termos sinônimos,
        //mas, é comum encontrarmos o termo função quando há retorno e método quando não há.

        public ContaCorrente(int agencia,int numero)
        {
            Agencia = agencia;
            Numero = numero;

            ContaCorrente.TotalDeContasCriadas++;
        }
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

