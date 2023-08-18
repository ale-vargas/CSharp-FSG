using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° numero");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"O maior valor informado foi: {num1}");
            }
            else
            {
                Console.WriteLine($"O maior valor informado foi: {num2}");
            }

            Console.ReadKey();
        }
    }
}
