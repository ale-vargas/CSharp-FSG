using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
21. Escreva um programa que preencha um vetor com 5 números inteiros informados pelo usuário e em seguida, 
exiba esses números na ordem inversa.
*/

namespace Exercicio21
{
    public class Program
    {
        EntradaDados entradaDados;
        public Program()
        {
            entradaDados = new EntradaDados();

            int[] vetor = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                vetor[i] = entradaDados.LeInteiro($"Posição {i}. Informe um número  inteiro: ");
            }

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine($"Posição {i}: {vetor[i]}.");
            }
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
