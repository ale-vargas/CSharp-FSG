using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 3: Carro

Descrição do Problema:
Crie uma classe chamada `Carro` com atributos para armazenar a marca, o modelo e a velocidade atual do carro. 
Implemente métodos para acelerar e desacelerar o carro.
*/

namespace Exercicio03
{
    public class Program
    {
        Carro meuCarro;
        public Program() 
        {
            Carro meuCarro = new Carro("Ford", "Focus", 60);
            meuCarro.ExibirDadosCarro();
            meuCarro.Acelerar(20);
            meuCarro.Desacelerar(10);

        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
