using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
20.Crie uma sub-rotina que receba um vetor de inteiros como parâmetro e retorne o maior valor presente no vetor.
*/

namespace Exercicio20
{
    public class Program
    {
        EntradaDados entradaDados;
        MaiorNum maiorNum;
        public Program()
        {
            entradaDados = new EntradaDados();
            maiorNum = new MaiorNum();

            Console.Write("Qual tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanho];
            for(int i = 0; i < tamanho; i++)
            {
                vetor[i] = entradaDados.LeInteiro($"Posição {i}. Informe o valor para o vetor: ");
            }

            int maiorValor = maiorNum.NumMaior(vetor);
            Console.WriteLine($"O maior valor no vetor é {maiorValor}.");
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
