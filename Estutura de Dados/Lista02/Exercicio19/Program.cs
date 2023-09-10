using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
19. Faça uma sub-rotina que calcule o fatorial de um número inteiro usando um loop for. 
A sub-rotina deve receber o número como parâmetro e retornar o fatorial.
*/

namespace Exercicio19
{
    public class Program
    {
        EntradaDados entradaDados;
        CalcularFatorial calcularFatorial;
        public Program() 
        { 
            entradaDados = new EntradaDados();
            calcularFatorial = new CalcularFatorial();
            int num = entradaDados.LeInteiro("Informe o número: ");
            int fat = calcularFatorial.CalcFatorial(num);
            Console.WriteLine($"O fatorial de {num} é {fat}.");
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
