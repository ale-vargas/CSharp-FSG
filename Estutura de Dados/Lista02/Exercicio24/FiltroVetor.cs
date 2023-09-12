using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24
{
    public class FiltroVetor
    {
        public FiltroVetor() { }

        public int NumMaior(int[] vetor)
        {
            int maior = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
            }
            return maior;
        }

        public int NumMenor(int[] vetor)
        {
            int menor = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
            return menor;
        }
    }
}
