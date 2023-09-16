using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 6: Aluno

Descrição do Problema:
Crie uma classe chamada `Aluno` com atributos para armazenar o nome, a matrícula e a nota de um aluno. 
Implemente um método para verificar se o aluno foi aprovado (nota maior ou igual a 6)
*/

namespace Exercicio06
{
    public class Program
    {
        Aluno aluno1;
        public Program()
        {
            Aluno aluno1 = new Aluno("João", "12345", 8.0);
            aluno1.DadosAluno();
            bool aprovado = aluno1.VerificarAprovacao();

        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
