using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            while (nodo != null)
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
            novoNodo.Proximo = _raiz;
            _raiz = novoNodo;
        }

        /*
        Exercício 5: Inversão da Lista
        Descrição do Problema: Implemente um método que inverta a ordem dos elementos na lista.
        Métodos Adicionais: - Inverter(): Inverte a ordem dos elementos na lista.
         */

        public void Inverter()
        {
            Nodo nodoAtual = _raiz;
            Nodo nodoAnterior = null;
            Nodo nodoProximo = null;

            while (nodoAtual != null)
            {
                nodoProximo = nodoAtual.Proximo;
                nodoAtual.Proximo = nodoAnterior;

                nodoAnterior = nodoAtual;
                nodoAtual = nodoProximo;
            }

            _raiz = nodoAnterior;
        }

        /*
        Exercício 6: Concatenação de Listas
        Descrição do Problema: Crie um método que concatene duas listas encadeadas.
        Métodos Adicionais: - Concatenar(outraLista): Concatena a lista atual com outra lista encadeada.
         */

        public Nodo PegarUltimoNodo()
        {
            if (_raiz == null)
            {
                return null;
            }

            Nodo nodo = _raiz;
            while (nodo.Proximo != null)
            {
                nodo = nodo.Proximo;
            }

            return nodo;
        }

        public void Concatenar(ListaEncadeada outraLista)
        {
            if (_raiz == null)
            {
                _raiz = outraLista._raiz;
            }
            else
            {
                Nodo ultimoNodo = PegarUltimoNodo();

                if (ultimoNodo != null)
                {
                    ultimoNodo.Proximo = outraLista._raiz;
                }
            }
        }

        /*
        Exercício 7: Remoção de Duplicatas
        Descrição do Problema: Implemente um método que remova elementos duplicados da lista.
        Métodos Adicionais: - RemoverDuplicatas(): Remove elementos duplicados da lista.
         */

        public void RemoverDuplicatas()
        {
            if (_raiz == null || _raiz.Proximo == null)
            {
                return;
            }

            Nodo nodoAtual = _raiz;

            while (nodoAtual != null)
            {
                Nodo nodoComparacao = nodoAtual;

                while (nodoComparacao.Proximo != null)
                {
                    if (nodoComparacao.Proximo.Conteudo == nodoAtual.Conteudo)
                    {
                        nodoComparacao.Proximo = nodoComparacao.Proximo.Proximo;
                    }
                    else
                    {
                        nodoComparacao = nodoComparacao.Proximo;
                    }
                }

                nodoAtual = nodoAtual.Proximo;
            }
        }
    }
}
