using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 5: Retângulo

Descrição do Problema:
Crie uma classe chamada `Retangulo` com atributos para armazenar a largura e a altura de um retângulo. 
Implemente um método para calcular a área do retângulo.
*/

namespace Exercicio05
{
    public class Program
    {
        Retangulo meuRetangulo;
        public Program()
        {
            meuRetangulo = new Retangulo(5.0, 3.0);
            double area = meuRetangulo.CalcularArea();
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
