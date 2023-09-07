using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 6. Elabore um programa que peça ao usuário para inserir um número e verifique se é positivo, negativo ou zero.

namespace Exercicio06
{
    public class Program
    {
        EntradaDados entradaDados;
        public Program()
        {
            entradaDados = new EntradaDados();
            double num = entradaDados.LeDouble("Digite um número: ");
            if (num < 0)
            {
                Console.WriteLine($"{num} é um número negativo");
            }
            else if (num > 0)
            {
                Console.WriteLine($"{num} é um número positivo.");
            }
            else
            {
                Console.WriteLine("O número é ZERO");
            }
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
