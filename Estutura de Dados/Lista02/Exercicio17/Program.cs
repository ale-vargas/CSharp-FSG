using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
17. Escreva uma sub-rotina que determine se um número é primo ou não. A sub-rotina deve receber o número 
como parâmetro e retornar verdadeiro ou falso.
*/

namespace Exercicio17
{
    public class Program
    {
        EntradaDados entradaDados;
        NumPrimos numPrimos;
        public Program()
        {
            entradaDados = new EntradaDados();
            numPrimos = new NumPrimos();

            int num = entradaDados.LeInteiro("Informe um número: ");
            bool tst = numPrimos.Primos(num);

            if (tst)
            {
                Console.WriteLine($"{num} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{num} não é um número primo.");
            }
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
