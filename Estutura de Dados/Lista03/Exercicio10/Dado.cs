using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Classes e Atributos:
• Classe: `Dado`
• Atributo: Nenhum
*/

namespace Exercicio10
{
    public class Dado
    {
        private Random random;

        public Dado()
        {
            random = new Random();
        }

        /*
        Métodos:
        • `RolarDado()`: Retorna um valor aleatório de 1 a 6.
        */

        public int RolarDado()
        {
            int resultado = random.Next(1, 7);
            return resultado;
        }
    }
}
