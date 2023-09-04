using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2. Desenvolva um programa que peça ao usuário para digitar seu nome e sua idade, e então exiba essas informações.
*/

namespace Exercicio02
{
    public class Program
    {
        EntradaDados entradaDados;
        public Program()
        {
            Console.Write("Digite seu nome: ");
            string nome  = Console.ReadLine();

            entradaDados = new EntradaDados();
            int idade = entradaDados.LeInteiro("Digite sua idade: ");

            Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos.");
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadLine() ;
        }
    }
}