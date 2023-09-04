using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
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
                    Console.Write("!! ERRO !! Valor inválido! Informe um número Inteiro: ");
                }
            } while (tst == false);
            return res;
        }
    }
}
