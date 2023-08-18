using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Program
    {
        static int CalcularFatorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalcularFatorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número maior que 0: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("ERRO! Número precisa ser maior que 0.");
            } else
            {
                int fatorial = CalcularFatorial(num);
                    Console.WriteLine($"O fatorial de {num} é {fatorial}.");
            }
            Console.ReadKey();
        }
    }
}
