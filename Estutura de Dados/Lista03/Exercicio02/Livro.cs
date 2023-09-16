using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Classes e Atributos:
• Classe: `Livro`
• Atributos: `titulo` (string), `autor` (string), `numeroPaginas` (int
*/

namespace Exercicio02
{
    public class Livro
    {
        private string titulo;
        private string autor;
        private int numeroPaginas;

        public Livro()
        {
            titulo = string.Empty;
            autor = string.Empty;
            numeroPaginas = 0;
        }

        public Livro(string titulo, string autor, int numeroPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.numeroPaginas = numeroPaginas;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }

        /*
        Métodos:
        • `MostrarInformacoes()`: Exibe as informações do livro
        */

        public void MostrarInformacoes()
        {
            Console.WriteLine("Informações do livro: ");
            Console.WriteLine($"Titulo: {Titulo}.");
            Console.WriteLine($"Autor: {Autor}.");
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}.");
        }
    }
}
