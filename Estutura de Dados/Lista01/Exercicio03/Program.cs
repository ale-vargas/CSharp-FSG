using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a operação matemática a ser usada (Ex.: + - * /): ");
            string sinal = Console.ReadLine();

            Console.WriteLine("Digite o 2° numero: ");
            double num2 = double.Parse(Console.ReadLine());

            double result;

            if (sinal == "+")
            {
                result = num1 + num2;
                Console.WriteLine($"O resultado da soma é: {result}");
            }
            else if (sinal == "-")
            {
                result = num1 - num2;
                Console.WriteLine($"O resultado da subtração é: {result}");
            }
            else if (sinal == "*")
            {
                result = num1 * num2;
                Console.WriteLine($"O resultado da multiplicação é {result}");
            }
            else
            {
                result = num1 / num2;
                Console.WriteLine($"O resultado da divisão é {result}");
            }
            Console.ReadKey();
        }
    }
}
