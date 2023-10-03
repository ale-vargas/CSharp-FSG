using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    public class Program
    {
        public Program()
        {
            ListaEncadeada lista = new ListaEncadeada();


            // Exercício 1: Lista Encadeada Simples Básica
            /* 
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Exibir(); // Saída: 10 -> 20 -> 30
            lista.Remover(20);
            lista.Exibir(); // Saída: 10 -> 30
            */


            // Exercício 2: Contagem de Elementos
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            int count = lista.ContarElementos();
            Console.WriteLine($"Número de elementos: {count}"); // Saída: Número de elementos: 3
            */

            // Exercício 3: Busca por Elemento
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            bool found = lista.Buscar(20);
            Console.WriteLine(found); // Saída: True
            bool notFound = lista.Buscar(40);
            Console.WriteLine(notFound); // Saída: False
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
