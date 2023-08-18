using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MaxValue;
            int menor = int.MinValue;
            int soma = 0;
            int quant = 0;

            Console.WriteLine("Digite números inteiros e para finalizar digite [.]:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == ".")
                {
                    break;
                }

                if (int.TryParse(input, out int num))
                {
                    soma += num;
                    quant++;

                    if (num < maior)
                    {
                        maior = num;
                    }
                    if (num > menor)
                    {
                        menor = num;
                    }
                }
                else
                {
                    Console.WriteLine("ERRO! Digite números inteiros e para finalizar digite [.]:");
                }
            }
            if (quant > 0)
            {
                double media = (double)soma / quant;

                Console.WriteLine($"O maior valor informado foi: {maior}");
                Console.WriteLine($"O menor valor informado foi: {menor}");
                Console.WriteLine($"Foram digitados {quant} numeros.");
                Console.WriteLine($"A média de valores é {media}.");
            }
            else
            {
                Console.WriteLine("Nenhum número valido foi informado.");
            }

            Console.ReadKey();
        }
    }
}
