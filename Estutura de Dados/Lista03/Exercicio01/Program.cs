using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 1: Conta Bancária

Descrição do Problema:
Crie uma classe chamada `ContaBancaria` com atributos para armazenar o número da conta, o nome do titular e o saldo. 
Implemente métodos para depositar e sacar dinheiro da conta.
*/

namespace Exercicio01
{
    public class Program
    {
        ContaBancaria minhaConta;
        public Program()
        {
            minhaConta = new ContaBancaria(12345, "João", 1000.0);
            minhaConta.ExibirDadosConta();
            minhaConta.Depositar(500.0);
            minhaConta.Sacar(200.0);
        }
        static void Main(string[] args)
        {
            Program execc = new Program();
            Console.ReadKey();
        }
    }
}
