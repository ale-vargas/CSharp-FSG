using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
15. Faça um programa que exiba a sequência de Fibonacci com os primeiros 10 termos usando um loop while.
*/

namespace Exercicio15
{
    internal class Program
    {
        public Program() 
        {
            Console.WriteLine("Sequência de Fibonacci:");

            int repet = 10;
            int cont = 0;
            int n1 = 1;
            int n2 = 1;
            bool tst = false;
           

            while (!tst)
            {
                if (cont < repet)
                {
                    Console.WriteLine(n1);
                }
                else
                {
                    tst = true;
                }
                int aux = n1 + n2;
                n1 = n2;
                n2 = aux;
                cont++;
            }
        }    
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
