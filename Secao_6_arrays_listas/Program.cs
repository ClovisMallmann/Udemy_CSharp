using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program{

        static void Main(string[] args)
        {

            System.Console.Clear();
            Console.Write("Entre com o numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());
            
            int[] Funcionarios;
            Funcionarios = new int[n];

             List<string> nomes = new List<String>();
             List<double> salarios = new List<double>();

            for (int i = 0; i < n; i++)
                  {
                     Console.Write("Entre com nome: ");
                     nomes.Insert(i,Console.ReadLine());

                     
                     Console.Write("Entre com salario: ");
                     salarios.Insert(i,double.Parse(Console.ReadLine()));
     
                  }   
            for (int i = 0; i < nomes.Count; i++)
            {
                System.Console.WriteLine(nomes[i] + " - " + salarios[i]);
            }

            Console.Write("\n Entre com a porcentagem de aumento de salario : ");
            double porcentagem = double.Parse(Console.ReadLine());
            
            Console.WriteLine("\n Novos salarios !");

            for (int i = 0; i < nomes.Count; i++)
            {
               double sal = salarios[i]*(1+porcentagem/100);
                System.Console.WriteLine(nomes[i] + " - " + sal.ToString("c2"));
            }

        }
    }
}


    