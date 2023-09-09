using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Escreva um programa que avalie se um número inserido pelo usuário é ímpar ou par.
*/

namespace Exercicio08
{
    public class Program
    {
        EntradaDados entradaDados;
        public Program()
        {   
            entradaDados = new EntradaDados();
            int num = entradaDados.LeInteiro("Informe um número inteiro: ");
            int rest = num % 2;
            if (rest == 0)
            {
                Console.WriteLine($"{num} é um número PAR.");
            }
            else
            {
                Console.WriteLine($"{num} é um número IMPAR.");
            }
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
