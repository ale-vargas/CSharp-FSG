using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    public class CalcularFatorial
    {
        public CalcularFatorial() { }

        public int CalcFatorial(int num)
        {
            int fatorial = 1;
            for (int i = num; i > 1; i--)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }
}