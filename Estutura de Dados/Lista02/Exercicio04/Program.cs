using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4. Crie um programa que peça ao usuário para inserir um número e então exiba o quadrado desse número.

namespace Exercicio04
{
    public class Program
    {
        EntradaDados entradaDados;
        public Program()
        {
            entradaDados = new EntradaDados();
            double num = entradaDados.LeDouble("Informe um número: ");
            Console.WriteLine($"O valor de {num} ao quadrado é de {num * num}.");
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
