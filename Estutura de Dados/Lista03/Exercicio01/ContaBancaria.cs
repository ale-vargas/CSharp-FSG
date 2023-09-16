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
        public int numeroConta { get; private set; }
        public string nomeTitular { get; private set; }
        public double saldo { get; private set; }


        public ContaBancaria(int numeroConta, string nomeTitular, double saldo)
        {
            this.numeroConta = numeroConta;
            this.nomeTitular = nomeTitular;
            this.saldo = saldo;
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
                Console.WriteLine($"Saldo na conta é de: R${saldo}.");
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
                    Console.WriteLine($"Saldo na conta é de: R${saldo}.");
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
    }
}
