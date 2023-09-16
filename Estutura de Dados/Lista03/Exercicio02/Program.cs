using Exercicio02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 2: Livro

Descrição do Problema:
Crie uma classe chamada `Livro` com atributos para armazenar o título, o autor e o número de páginas. 
Implemente um método para exibir informações sobre o livro.
*/

namespace Exercicio02
{
    public class Program
    {
        Livro livro;
        public Program() 
        { 
            livro = new Livro("Aventuras de Alice", "Lewis Carroll", 200);
            livro.MostrarInformacoes();
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
