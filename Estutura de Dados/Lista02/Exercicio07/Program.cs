using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
7. Crie um programa que determine se um aluno foi aprovado em uma disciplina com base em sua nota. Se a nota for maior
ou igual a 7, exiba "Aprovado", caso contrário, exiba "Reprovado".
*/

namespace Exercicio07
{
    public class Program
    {   
        EntradaDados entradaDados;
        public Program()
        {
           entradaDados = new EntradaDados();
            double nota = entradaDados.LeDouble("Informe a nota do aluno: ");
            if (nota >= 7 && nota <= 10)
            {
                Console.WriteLine($"Aluno APROVADO, nota final: {nota}.");
            }
            else if (nota < 7 && nota >= 0)
            {
                Console.WriteLine($"Aluno REPROVADO, nota final: {nota}.");
            } else
            {
                Console.WriteLine("Valor invalido informado para nota final.");
            }
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
