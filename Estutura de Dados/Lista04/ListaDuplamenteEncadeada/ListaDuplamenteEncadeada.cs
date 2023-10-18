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

        /*
       Exercício 2: Contagem de Elementos
       Descrição do Problema: Adicione um método que retorne o número de elementos na lista.
       Métodos Adicionais: - ContarElementos(): Retorna o número de elementos na lista.
        */

        public int ContarElementos()
        {
            int contador = 0;
            Nodo nodo = _raiz;

            while (nodo != null)
            {
                contador++;
                nodo = nodo.Proximo;
            }
            return contador;
        }

        /*
        Exercício 3: Busca por Elemento
        Descrição do Problema: Implemente um método que busque um elemento na lista.
        Métodos Adicionais: - Buscar(valor): Retorna true se o elemento com o valor especificado estiver na lista, senão retorna false.
        */

        public bool Buscar(int valor)
        {
            Nodo nodo = _raiz;

            do
            {
                if (nodo.Conteudo == valor)
                {
                    return true;
                }
                nodo = nodo.Proximo;
            }
            while (nodo != null);

            return false;
        }

        /*
        Exercício 4: Inserção no Início
        Descrição do Problema: Permita a inserção de elementos no início da lista.
        Métodos Adicionais: - InserirNoInicio(valor): Insere um elemento no início da lista.
        */

        public void InserirNoInicio(int valor)
        {
            Nodo novoNodo = new Nodo(valor);

            if (_raiz != null)
            {
                novoNodo.Proximo = _raiz;
                _raiz.Anterior = novoNodo;
            }

            _raiz = novoNodo;
        }



        public void Inverter()
        {
            Nodo nodoAtual = _raiz;
            Nodo nodoAnterior = null;
            Nodo nodoProximo = null;

            while (nodoAtual != null)
            {
                nodoProximo = nodoAtual.Proximo;

                nodoAtual.Proximo = nodoAnterior;
                nodoAtual.Anterior = nodoProximo;

                nodoAnterior = nodoAtual;
                nodoAtual = nodoProximo;
            }
            _raiz = nodoAnterior;
        }





    }
}
