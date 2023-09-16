using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Classes e Atributos:
• Classe: `Retangulo`
• Atributos: `largura` (double), `altura` (double)
*/

namespace Exercicio05
{
    public class Retangulo
    {
        private double largura;
        private double altura;

        public Retangulo()
        {
            largura = 0;
            altura = 0;
        }

        public Retangulo(double largura, double altura) 
        { 
            this.largura = largura;
            this.altura = altura;
        }

        public double Largura
        {
            get { return largura; }
            set { largura = value; }
        } 
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        /*
        Métodos:
        • `CalcularArea()`: Retorna a área do retângulo(largura* altura).
        */

        public double CalcularArea()
        {
            double area = largura*altura;
            Console.WriteLine($"A área é: {area} m².");

            return area;
        }

    }
}
