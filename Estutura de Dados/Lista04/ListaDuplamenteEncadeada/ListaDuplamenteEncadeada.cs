using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
    public class ListaDuplamenteEncadeada
    {
        private Nodo _raiz;

        /* Exercício 1: Lista Duplamente Encadeada 
        Descrição do Problema: Crie uma lista encadeada simples que permita a inserção e remoção de elementos. */

        // Inserir(valor): Insere um elemento no final da lista.

        public void Inserir(int valor)
        {
            Nodo novoNodo = new Nodo(valor);

            if (_raiz == null)
            {
                _raiz = novoNodo;
            }
            else
            {
                Nodo nodo = _raiz;
                while (nodo.Proximo != null)
                {
                    nodo = nodo.Proximo;
                }

                novoNodo.Anterior = nodo;
                nodo.Proximo = novoNodo;
            }
        }

        // Exibir(): Exibe os elementos da lista.
        public void Exibir()
        {
            if (_raiz == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            Nodo nodo = _raiz;

            while (nodo != null)
            {
                Console.Write($"{nodo.Conteudo}");

                if (nodo.Proximo != null)
                {
                    Console.Write($" -> ");
                }

                nodo = nodo.Proximo;
            }

            Console.WriteLine("");
        }

        //Remover(valor): Remove a primeira ocorrência do elemento com o valor especificado. 
        public void Remover(int valor)
        {
            if (_raiz == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            if (_raiz.Conteudo == valor)
            {
                _raiz = _raiz.Proximo;
                if (_raiz != null)
                {
                    _raiz.Anterior = null;
                }
                return;
            }

            Nodo nodoAtual = _raiz;

            while (nodoAtual != null && nodoAtual.Conteudo != valor)
            {
                nodoAtual = nodoAtual.Proximo;
            }

            if (nodoAtual == null)
            {
                Console.WriteLine($"Valor não encontrado na lista.");
                return;
            }

            if (nodoAtual.Anterior != null)
            {
                nodoAtual.Anterior.Proximo = nodoAtual.Proximo;
            }

            if (nodoAtual.Proximo != null)
            {
                nodoAtual.Proximo.Anterior = nodoAtual.Anterior;
            }
        }

    }
}
