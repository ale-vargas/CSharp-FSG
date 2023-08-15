using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° numero:");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine($"O resultado da soma é {result}");
            Console.ReadKey();
        }
    }
}
