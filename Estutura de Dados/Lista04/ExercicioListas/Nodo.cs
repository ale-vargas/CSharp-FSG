﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExercicioListas
{
    // Classe Nodo com um atributo para armazenar o valor do elemento e um atributo para o próximo nodo.
    public class Nodo
    {
        public int Conteudo { get; set; }
        public Nodo Proximo { get; set; }

        public Nodo(int conteudo)
        {
            Conteudo = conteudo;
        }
    }
}
