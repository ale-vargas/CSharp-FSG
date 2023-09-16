using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Classes e Atributos:
• Classe: `Produto`
• Atributos: `nome` (string), `preco` (double), `quantidadeEmEstoque` (int)
*/

namespace Exercicio07
{
    public class Produto
    {
        private string nome;
        private double preco;
        private int quantidadeEmEstoque;

        public Produto()
        {
            nome = string.Empty;
            preco = 0;
            quantidadeEmEstoque = 0;
        }

        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int QuantidadeEmEstoque
        {
            get { return quantidadeEmEstoque; }
            set { quantidadeEmEstoque = value; }
        }
        /*
         Métodos:
        • `AdicionarEstoque(int quantidade)`: Aumenta a quantidade em estoque em 
        `quantidade` unidades.
        • `RemoverEstoque(int quantidade)`: Diminui a quantidade em estoque em `quantidade` unidades
         */

        public void AdicionarEstoque(int valor)
        {
            quantidadeEmEstoque += valor;
            Console.WriteLine($"Quantidade em estoque após adicionar: {QuantidadeEmEstoque}");
        }

        public void RemoverEstoque(int valor)
        {
            quantidadeEmEstoque -= valor;
            Console.WriteLine($"Quantidade em estoque após remover: {QuantidadeEmEstoque}");
        }
        public void DadosProduto()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade inicial em estoque: {QuantidadeEmEstoque}");
        }
    }
}
