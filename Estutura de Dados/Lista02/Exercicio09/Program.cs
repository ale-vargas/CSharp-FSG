using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
9. Desenvolva um programa que determine se um ano é bissexto ou não. Um ano é bissexto se for divisível por 4, 
exceto quando é divisível por 100. No entanto, anos divisíveis por 400 também são bissextos.
*/

namespace Exercicio09
{
    public class Program
    {
        EntradaDados entradaDados;
        public Program()
        {
            entradaDados = new EntradaDados();
            int ano = entradaDados.LeInteiro("Informe o ano: ");

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine($"{ano} é um ano bissexto.");
            }
            else
            {
                Console.WriteLine($"{ano} não é um ano bissexto.");
            }

        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadLine();
        }
    }
}
