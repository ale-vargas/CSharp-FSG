using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 9: Agenda

Descrição do Problema:
Crie uma classe chamada `Agenda` que pode armazenar até 5 contatos. Cada contato deve conter um nome e um número de telefone. 
Implemente métodos para adicionar e listar contatos.
*/

namespace Exercicio09
{
    public class Program
    {
        Agenda minhaAgenda;
        public Program() 
        {
            Agenda minhaAgenda = new Agenda();
            minhaAgenda.AdicionarContato("Maria", "123-456-7890");
            minhaAgenda.AdicionarContato("João", "987-654-3210");
            minhaAgenda.ListarContatos();
        }
        static void Main(string[] args)
        {
            Program exe = new Program();
            Console.ReadKey();
        }
    }
}
