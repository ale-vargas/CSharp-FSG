using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 10: Jogo de Dados

Descrição do Problema:
Crie uma classe chamada `Dado` que representa um dado de seis faces. 
Implemente um método para rolar o dado e obter um valor aleatório de 1 a 6
*/

namespace Exercicio10
{
    public class Program
    {
        Dado meuDado;
        public Program() 
        {
            meuDado = new Dado();
            int resultado = meuDado.RolarDado();
            Console.WriteLine(resultado);
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
