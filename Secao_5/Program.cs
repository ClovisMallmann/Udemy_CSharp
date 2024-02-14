using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
            //Neste escopo é tudo que tem que ser executado de primeiro contato.
            // Void porque não precisa retornar algo.
        {
            //Instanciando a classe fora para acesso global.
            Banco.ContaBancaria conta;

            Console.Clear();
            Console.Write("Entre com o numero da conta: ");
            //variavel temporaria para receber o valor da conta
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da conta: ");
            string titular = (Console.ReadLine());

            Console.Write("Haverá deposito inicial ? ");
            //variavel temporaria para receber o valor da conta
            char resp = char.Parse(Console.ReadLine());


            //Verifica a resposta do cliente e atribui um valor à uma variavel qualquer.
            if (!(resp == 's' || resp == 'S'))
            {
                //Chamando o Construtor de 2 argumentos caso a resposta seja N.
                conta = new Banco.ContaBancaria(numero, titular);
            }
            else
            {
                Console.Write("Digite o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Chamando o contrutor com 3 argumentos caso a resposta seja S para trabalhar
                //com a classe ContaBancaria que é restrita de acesso.
                conta = new Banco.ContaBancaria(numero, titular, depositoInicial);
            }
            Console.WriteLine("\nDados da conta");
            Console.WriteLine(conta);

            //Entrada de dados para deposito, chama o objeto conta e seu metodo deposito.
            Console.Write("\nEntre com o valor do deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta " + conta + " atualizados");
            
            //Entrada de dados para saque, chama o objeto conta e seu metodo Saque.
            Console.Write("\nEntre com o valor do saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta " + conta + " atualizados");
        }
    }

}
    
        

        