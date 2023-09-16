using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 8: Triângulo

Descrição do Problema:
Crie uma classe chamada `Triangulo` com atributos para armazenar os comprimentos dos três lados de um triângulo. 
Implemente um método para verificar se o triângulo é válido (a soma de dois lados deve ser maior que o terceiro).
*/

namespace Exercicio08
{
    public class Program
    {
        public Program()
        {
            Triangulo meuTriangulo = new Triangulo(3.0, 4.0, 5.0);
            bool valido = meuTriangulo.VerificarValidade();
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
