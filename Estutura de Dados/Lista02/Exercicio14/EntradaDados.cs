using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    public class EntradaDados
    {
        public EntradaDados() { }

        public int LeInteiro(string msg)
        {
            string aux;
            int res;
            bool tst = false;

            do
            {
                Console.Write(msg);
                aux = Console.ReadLine();
                if (int.TryParse(aux, out res))
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
