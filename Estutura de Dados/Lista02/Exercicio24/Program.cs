using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
24. Faça um programa que encontre o maior e o menor valor em um vetor de inteiros e exiba esses valores.
*/

namespace Exercicio24
{
    public class Program
    {
        EntradaDados entradaDados;
        FiltroVetor filtroVetor;
        public Program()
        {
            entradaDados = new EntradaDados();
            filtroVetor = new FiltroVetor();

            Console.Write("Qual tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = entradaDados.LeInteiro($"Posição {i}. Informe o valor para o vetor: ");
            }

            int maiorValor = filtroVetor.NumMaior(vetor);
            Console.WriteLine($"O maior valor no vetor é {maiorValor}.");

            int menorValor = filtroVetor.NumMenor(vetor);
            Console.WriteLine($"O menor valor no vetor é {menorValor}.");
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
