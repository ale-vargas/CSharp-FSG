using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
25. Escreva um programa que solicite ao usuário números inteiros até que um valor negativo seja inserido.
Em seguida, exiba a média dos números digitados
*/

namespace Exercicio25
{
    public class Program
    {
        EntradaDados entradaDados;

        public Program()
        {
            entradaDados = new EntradaDados();
            int tamanho = entradaDados.LeInteiro("Qual tamanho do vetor: ");

            int[] numeros = new int[tamanho];
            int contador = 0;
            int soma = 0;

            Console.WriteLine("Informe alguns números, para finalizar digite um número negativo.");

            while (contador < tamanho)
            {
                int numero = entradaDados.LeInteiro($"Posição {contador}. Informe um número: ");

                if (numero < 0)
                {
                    break;
                }

                numeros[contador] = numero;
                soma += numero;
                contador++;
            }

            if (contador == 0)
            {
                Console.WriteLine("Nenhum número foi informado.");
            }
            else
            {
                double media = soma / contador;
                Console.WriteLine($"A média dos números é: {media}");
            }
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}