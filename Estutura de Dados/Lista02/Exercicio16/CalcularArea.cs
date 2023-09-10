using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    public class CalcularArea
    {
        public CalcularArea() { }

        public double AreaCirculo(double raio)
        {
            double area = Math.PI * Math.Pow(raio, 2);
            return area;
        }
    }
}
