using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    public class EntradaDados
    {
        public EntradaDados() { }

        public double LeDouble(string msg)
        {
            string aux;
            double res;
            bool tst = false;

            do
            {
                Console.Write(msg);
                aux = Console.ReadLine();
                if (double.TryParse(aux, out res))
                {
                    tst = true;
                }
                else
                {
                    Console.WriteLine("!! ERRO !! Valor inválido!");
                }
            } while (tst == false);
            return res;
        }
    }
}
