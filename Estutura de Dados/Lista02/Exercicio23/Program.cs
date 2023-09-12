using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
23. Desenvolva um programa que receba um vetor de strings contendo nomes de pessoas e exiba 
todos os nomes que começam com a letra "A".
*/

namespace Exercicio23
{
    public class Program
    {
        public Program() 
        {
            Console.Write("Qual tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            string[] vetor = new string[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Inforrme um nome: ");
                vetor[i] = Console.ReadLine();
            }

            for (int i = 0; i < tamanho; i++)
            {
                string nome = vetor[i];
                if (nome.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(nome);
                }
            }
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
