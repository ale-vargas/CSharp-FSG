using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Classes e Atributos:
• Classe: `Agenda`
• Atributos: `contatos` (array de strings para nomes), `telefones` (array de strings para números de telefone)
*/

namespace Exercicio09
{
    public class Agenda
    {
        private string[] contatos;
        private string[] telefones;
        private int espacoAgenda;

        public Agenda()
        {
            contatos = new string[5];
            telefones = new string[5];
            espacoAgenda = 0;
        }

        /*
        Métodos:
        • - `AdicionarContato(string nome, string telefone)`: Adiciona um contato à agenda.
        • - `ListarContatos()`: Lista os contatos da agenda.
        */

        public void AdicionarContato(string nome, string telefone)
        {
            if (espacoAgenda < 5)
            {
                contatos[espacoAgenda] = nome;
                telefones[espacoAgenda] = telefone;
                espacoAgenda++;
            }
            else
            {
                Console.WriteLine("A agenda está cheia.");
            }
        }
        public void ListarContatos()
        {
            Console.WriteLine("-- Agenda --");
            for (int i = 0; i < espacoAgenda; i++)
            {
                Console.WriteLine($"Nome: {contatos[i]}, telefone: {telefones[i]}");
            }
        }
    }
}
