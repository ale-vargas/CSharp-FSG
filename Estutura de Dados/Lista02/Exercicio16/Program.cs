using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
16. Crie uma sub-rotina que receba o raio de um círculo como parâmetro e retorne a área desse círculo.
*/

namespace Exercicio16
{
    public class Program
    {
        EntradaDados entradaDados;
        CalcularArea calcularArea;
        public Program()
        {
            entradaDados = new EntradaDados();
            calcularArea = new CalcularArea();

            double raio = entradaDados.LeDouble("Informe o raio do circulo: "); 
            double area = calcularArea.AreaCirculo(raio);
            Console.WriteLine($"A área do círculo é {area} metros.");
        }

        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
