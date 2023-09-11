using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
22. Crie um programa que calcule a média dos valores em um vetor de números decimais.
*/
namespace Exercicio22
{
    public class Program
    {
        public Program() 
        {
            double[] vetor = {2.4, 3.8, 7.5, 5.2, 6.9};

            double soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i]; 
            }

            double media = soma / vetor.Length; 

            Console.WriteLine($"A média dos valores é: {media}");
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
