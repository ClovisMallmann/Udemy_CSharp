using System.Globalization;

namespace Banco
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Cria-se Construtor para trabalhar com as variaveis privadas de uma classe
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        //Construtor com 3 argumentos
        //uso da palavra this para reaproveitar os comandos anteriores (Numero e TItular)
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        //Operação de Depósito
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        //Operação de Saque
        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }



        //Um método override fornece uma nova implementação de um membro herdado de uma classe base.
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular "
                + Titular
                + ", Saldo $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
