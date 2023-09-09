using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

/*
13. Crie um programa que calcule a média de uma lista de números digitados pelo usuário. 
O programa deve parar a leitura quando o usuário inserir um número negativo. 
*/

namespace Exercicio13
{
    public class Program
    {
        EntradaDados entradaDados;
        public Program()
        {
            entradaDados = new EntradaDados();
            Console.WriteLine("Informe alguns números, para finalizar digite um númro negativo.");

            double total = 0;
            int quant = 0;
            bool tst = true;

            while (tst)
            {
                double num = entradaDados.LeDouble("Digite um valor: ");

                if (num < 0)
                {
                    tst = false;
                }
                else
                {
                    total += num;
                    quant++;
                }
            }
            if (quant == 0)
            {
                Console.WriteLine("Nenhum valor informado.");
            }
            else
            {
                double media = total / quant;
                Console.WriteLine($"A média dos valores foi {media}");
            }
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
