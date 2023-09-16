using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

/*
Classes e Atributos:
• Classe: `Aluno`
• Atributos: `nome` (string), `matricula` (string), `nota` (double) 
*/

namespace Exercicio06
{
    public class Aluno
    {
        private string nome;
        private string matricula;
        private double nota;

        public Aluno() 
        {
            nome = string.Empty;
            matricula = string.Empty;
            nota = 0;
        }

        public Aluno(string nome, string matricula, double nota)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.nota = nota;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }
        /*
        Métodos:
        • `VerificarAprovacao()`: 
        Retorna true se o aluno foi aprovado (nota maior ou igual a 6), caso contrário, retorna false
        */

        public bool VerificarAprovacao()
        {
            if (nota >= 6)
            {
                Console.WriteLine("Aluno Aprovado!");
                return true;
            }
            else
            {
                Console.WriteLine("Aluno Reprovado!");
                return false;
            }
        }
        public void DadosAluno()
        {
            Console.WriteLine($"Nome: {Nome}.");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Média: {Nota}");
        }
    }
}
