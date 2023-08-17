using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° número: ");
            int num2 = int.Parse(Console.ReadLine());

            int min = Math.Min(num1, num2);
            int max = Math.Max(num1, num2);

            int result = 0;
            for (int i = min; i <= max; i++)
            {
                result += i;
            }
            Console.WriteLine($"A soma dos números no intervalo de {min} até {max} é {result}.");

            Console.ReadKey();
        }
    }
}
