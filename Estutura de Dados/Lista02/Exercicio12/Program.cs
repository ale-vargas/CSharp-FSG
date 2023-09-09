using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
12. Escreva um programa que peça ao usuário para adivinhar um número inteiro de 1 a 100. O programa deve fornecer 
dicas se o número digitado é maior ou menor que o número correto, e contar quantas tentativas foram necessárias.
*/

namespace Exercicio12
{
    public class Program
    {
        EntradaDados entradaDados;
        public Program()
        {
            entradaDados = new EntradaDados();
            Random random = new Random();
            int certo = random.Next(1, 101);
            int quant = 0;
            bool tst = false;

            while (!tst)
            {
                int num = entradaDados.LeInteiro("Informe um número: ");
                quant++;

                if (num < 1 || num > 100)
                {
                    Console.WriteLine("Informe números entre 1 e 100.");
                }
                else if (num < certo)
                {
                    Console.WriteLine("Tente um número maior.");
                }
                else if (num > certo)
                {
                    Console.WriteLine("Tente um número menor.");
                }
                else
                {
                    tst = true;
                }
            }
            Console.WriteLine($"Você acertou o número {certo} em {quant} tentativas.");
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
