using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. Faça um programa que solicite ao usuário que insira seu nome e, em seguida, o cumprimente usando a mensagem "Olá, [nome]!".

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor insira seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}.");
            Console.ReadKey();
        }
    }
}
