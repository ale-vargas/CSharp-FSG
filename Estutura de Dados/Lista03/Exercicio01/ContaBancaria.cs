using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
- Classe: `ContaBancaria`
- Atributos: `numeroConta` (int), `nomeTitular` (string), `saldo` (double)
*/

namespace Exercicio01
{
    public class ContaBancaria
    {
        private int numeroConta;
        private string nomeTitular;
        private double saldo;

        public ContaBancaria()
        {
            numeroConta = 0;
            nomeTitular = "";
            saldo = 0;
        }
        public ContaBancaria(int conta, string nome, double saldo)
        {
            numeroConta = conta;
            nomeTitular = nome;
            this.saldo = saldo;
        }

        public int NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }
        public string NomeTitular
        {
            get { return nomeTitular; }
            set { nomeTitular = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        /*
         Métodos:
        - `Depositar(double valor)`: Adiciona o valor especificado ao saldo.
        - `Sacar(double valor)`: Retira o valor especificado do saldo, desde que haja saldo suficiente.
        */

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Realizado depósito no valor de: R$ {valor}.");
                Console.WriteLine($"Saldo na conta é de: R$ {saldo}.");
            }
            else
            {
                Console.WriteLine("ERRO! Nenhum valor informado para depósito.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                if (saldo >= valor)
                {
                    saldo -= valor;
                    Console.WriteLine($"Realizado saque no valor de: R$ {valor}.");
                    Console.WriteLine($"Saldo na conta é de: R$ {saldo}.");
                }
                else
                {
                    Console.WriteLine($"Saque NÃO aprovado. Saldo insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("ERRO! Nenhum valor informado para saque.");
            }
        }
        public void ExibirDadosConta()
        {
            Console.WriteLine($"Número da Conta: {NumeroConta}");
            Console.WriteLine($"Nome do Titular: {NomeTitular}");
            Console.WriteLine($"Saldo da Conta: R$ {Saldo}");
        }
    }
}