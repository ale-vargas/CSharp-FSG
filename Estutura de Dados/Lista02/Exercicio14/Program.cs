using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
14. Desenvolva um programa que solicite ao usuário para digitar uma senha. Continue pedindo até que o 
usuário insira a senha correta (por exemplo, "1234").
*/

namespace Exercicio14
{
    internal class Program
    {
        EntradaDados entradaDados;
        public Program()
        {
            entradaDados = new EntradaDados();
            int senha = 1234;
            bool tst = false;

            while (!tst)
            {
                int num = entradaDados.LeInteiro("Digite a senha numérica: ");
                if (num == senha)
                {
                    Console.WriteLine("Senha Correta!");
                    tst = true;
                }
            }
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
