using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
3. Escreva um programa que converta uma string contendo um número inteiro em um valor inteiro real e exiba o dobro desse valor.
*/

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txtNum = "5";
            double num = double.Parse(txtNum);
            Console.WriteLine($"O dobro de {num} é {num * 2}.");
            Console.ReadKey();
        }
    }
}
