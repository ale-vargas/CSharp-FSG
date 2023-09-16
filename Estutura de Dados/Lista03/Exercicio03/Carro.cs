using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Classes e Atributos:
• Classe: `Carro`
• Atributos: `marca` (string), `modelo` (string), `velocidadeAtual` (int)
*/

namespace Exercicio03
{
    public class Carro
    {
        private string marca;
        private string modelo;
        private int velocidadeAtual;

        public Carro()
        {
            marca = string.Empty;
            modelo = string.Empty;
            velocidadeAtual = 0;
        }

        public Carro(string marca, string modelo, int velocidadeAtual)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.velocidadeAtual = velocidadeAtual;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        } 
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int VelocidadeAtual
        {
            get { return velocidadeAtual; }
            set { velocidadeAtual = value; }
        }

        /*    
        Métodos:
        • `Acelerar(int aumento)`: Aumenta a velocidade atual do carro em `aumento` km/h.
        • `Desacelerar(int reducao)`: Reduz a velocidade atual do carro em `reducao` km/h.
        */

        public void Acelerar(int valor)
        {
            velocidadeAtual += valor;
            Console.WriteLine($"Velodidade após acelerar é de {velocidadeAtual} Km/h.");
        }

        public void Desacelerar(int valor)
        {
            velocidadeAtual -= valor;
            Console.WriteLine($"Velodidade após desacelerar é de {velocidadeAtual} Km/h.");
        }
        public void ExibirDadosCarro()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Velocidade Inicial: {velocidadeAtual}");
        }
    }
}
