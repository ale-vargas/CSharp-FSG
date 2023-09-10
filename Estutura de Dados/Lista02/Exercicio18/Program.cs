using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
18. Desenvolva uma sub-rotina que receba uma string e retorne a mesma string, mas com todas as letras maiúsculas.
*/

namespace Exercicio18
{
    public  class Program
    {
        LetrasMaiusculas letrasMaiusculas;
        public Program() 
        { 
            letrasMaiusculas = new LetrasMaiusculas();
            Console.WriteLine("Escreva algo: ");
            string txt = Console.ReadLine();
            string txtUpper = letrasMaiusculas.ConverteMaiusculas(txt);
            Console.WriteLine(txtUpper);
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
