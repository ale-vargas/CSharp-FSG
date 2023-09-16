using Exercicio04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

/*
Classes e Atributos:
• Classe: `Pessoa`
• Atributos: `nome` (string), `idade` (int), `endereco` (string)
*/

namespace Exercicio04
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string endereco;

        public Pessoa()
        {
            nome = string.Empty;
            idade = 0;
            endereco = string.Empty;
        }

        public Pessoa(string nome, int idade, string endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        /*
        Métodos:
        • `MostrarDetalhes()`: Exibe os detalhes da pessoa.
        */

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Nome: {nome}.");
            Console.WriteLine($"Idade: {idade} anos.");
            Console.WriteLine($"Endereço: {endereco}.");
        }
    }
}
