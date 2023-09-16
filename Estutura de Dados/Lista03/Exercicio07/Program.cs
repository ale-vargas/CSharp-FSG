using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 7: Produto
Descrição do Problema:
Crie uma classe chamada `Produto` com atributos para armazenar o nome, o preço e a quantidade em estoque de um produto. 
Implemente métodos para aumentar e diminuir a quantidade em estoque.
*/

namespace Exercicio07
{
    public class Program
    {
        Produto produto1;
        public Program() 
        {
            Produto produto1 = new Produto("Camiseta", 20.0, 50);
            produto1.DadosProduto();
            produto1.AdicionarEstoque(10);
            produto1.RemoverEstoque(5);
        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
