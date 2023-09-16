using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 4: Pessoa

Descrição do Problema:
Crie uma classe chamada `Pessoa` com atributos para armazenar o nome, a idade e o endereço de uma pessoa. 
Implemente um método para exibir os detalhes da pessoa.
*/

namespace Exercicio04
{
    
    public class Program
    {   
        Pessoa pessoal;
        public Program() 
        {
            Pessoa pessoa1 = new Pessoa("Maria", 30, "Rua ABC, 123");
            pessoa1.MostrarDetalhes();

        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
