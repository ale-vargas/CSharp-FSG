using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
1. Crie um programa que declare duas variáveis do tipo inteiro atribua valores a elas e exiba a soma desses valores.
*/

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 4;
            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
            Console.ReadKey();
        }
    }
}
