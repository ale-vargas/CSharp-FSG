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
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Exibir(); // Saída: 10 -> 20 -> 30
            lista.Remover(20);
            lista.Exibir(); // Saída: 10 -> 30
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
