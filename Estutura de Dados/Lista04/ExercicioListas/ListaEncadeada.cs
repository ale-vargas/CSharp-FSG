using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    // Classe ListaEncadeada com um atributo para o nodo inicial.

    public class ListaEncadeada
    {
        private Nodo _raiz;

        /* Exercício 1: Lista Encadeada Simples Básica 
        Descrição do Problema: Crie uma lista encadeada simples que permita a inserção e remoção de elementos. */

        // Inserir(valor): Insere um elemento no final da lista.
        public void Inserir(int valor)
        {
            Nodo novoNodo = new Nodo(valor);
            
            if (_raiz == null)
            {
                _raiz = novoNodo;
                return;
            }
            
            Nodo nodo = _raiz;
            
            while (nodo.Proximo != null)
            {
                nodo = nodo.Proximo;
            }
            nodo.Proximo = novoNodo;
        }

        // Exibir(): Exibe os elementos da lista.
        public void Exibir()
        {
            if (_raiz == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }
            
            Console.Write(_raiz.Conteudo);
            
            Nodo nodo = _raiz.Proximo;
            
            while (nodo !=  null)
            {
                Console.Write($" -> {nodo.Conteudo}");
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
                return;
            }
            
            Nodo nodoAnterior = null;
            Nodo nodoAtual = _raiz;
            
            while (nodoAtual != null && nodoAtual.Conteudo != valor)
            {
                nodoAnterior = nodoAtual;
                nodoAtual = nodoAtual.Proximo;
            }

            if (nodoAtual == null)
            {
                Console.WriteLine($"Valor não encontrado na lista.");
                return;
            }

            nodoAnterior.Proximo = nodoAtual.Proximo;
        }
    }
}
