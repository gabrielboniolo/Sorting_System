using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_System
{
    internal class Sort
    {
        public static int[] Selection(int[] vetor)
        {
            int aux;

            for(int i = 0; i < vetor.Length - 1; i++)
            {
                for(int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
            return vetor;
        }

        public static int[] Bubble(int[] vetor)
        {
            int aux;
            for(int i = 0; i < vetor.Length - 1; i ++)
            {
                for(int j = 0; j < vetor.Length - i - 1; j++)
                {
                    if(vetor[j] > vetor[j + 1]) {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            return vetor;
        }

    }
}
