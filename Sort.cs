using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Grupo_D
{
    class Sort
    {
        public Sort() { }
        public int troca = 0;
        //Insert Sort
        public int[] Insert_Sort(int[] array)
        {
            int value, flag;
            for (var i = 1; i < array.Length; i++)
            {
                value = array[i];
                flag = 0;
                for (var j = i - 1; j >= 0 && flag != 1;)
                {
                    if (value < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = value;
                        troca++;
                    }
                    else flag = 1;
                }
            }
            return array;
        }

        //Select Sort*
        public int[] Select_Sort(int[] array)
        {
            int min, aux;
            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                //condição faz não ocorrer a troca se a posição de troca for a mesma 
                aux = array[i];
                array[i] = array[min];
                array[min] = aux;
                troca++;

            }
            Console.WriteLine("Numero de trocas: " + troca);
            return array;
        }

        //Bubble Sort
        public int[] BubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        troca++;
                    }
                }
            }
            Console.WriteLine("Numero de trocas: " + troca);
            return vetor;
        }

        //Merge Sort
        public int[] Merge_Sort(int[] array)
        {
            int[] esq;
            int[] dir;
            int[] result = new int[array.Length];
            if (array.Length <= 1)
            {
                return array;
            }

            int meio = array.Length / 2;
            esq = new int[meio];

            if (array.Length % 2 == 0)
            {
                dir = new int[meio];
            }
            else
            {
                dir = new int[meio + 1];
            }
            for (int i = 0; i < meio; i++)
            {
                esq[i] = array[i];
            }
            int x = 0;
            for (int i = meio; i < array.Length; i++)
            {
                dir[x] = array[i];
                x++;
            }
            esq = Merge_Sort(esq);
            dir = Merge_Sort(dir);
            result = Merge(esq, dir);
            return result;
        }
        public int[] Merge(int[] esq, int[] dir)
        {
            int resultado = dir.Length + esq.Length;
            int[] result = new int[resultado];
            int iLeft = 0, iRight = 0, iResultado = 0;
            while (iLeft < esq.Length || iRight < dir.Length)
            {
                if (iLeft < esq.Length && iRight < dir.Length)
                {
                    if (esq[iLeft] <= dir[iRight])
                    {
                        result[iResultado] = esq[iLeft];
                        iLeft++;
                        iResultado++;
                    }
                    else
                    {
                        result[iResultado] = dir[iRight];
                        iRight++;
                        iResultado++;
                        troca++;
                    }
                }
                else if (iLeft < esq.Length)
                {
                    result[iResultado] = esq[iLeft];
                    iLeft++;
                    iResultado++;
                }
                else if (iRight < dir.Length)
                {
                    result[iResultado] = dir[iRight];
                    iRight++;
                    iResultado++;
                }
            }
            return result;
        }

        //Quick Sort
        public int[] Quick_Sort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            QuickSort(vetor, inicio, fim);

            return vetor;
        }
        private void QuickSort(int[] vetor, int inicio, int fim)
        {
            troca++;
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int trocas = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = trocas;
                        i++;
                        f--;
                        trocas++;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                QuickSort(vetor, inicio, f - 1);
                QuickSort(vetor, f + 1, fim);
            }
        }

        // Shell Sort
        public int[] ShellSort(int[] vetor)
        {
            int i, j, val, comp = 0;
            int gap = 1;
            while (gap < vetor.Length)
            {
                gap = 3 * gap + 1;
            }
            while (gap > 1)
            {
                gap /= 3;
                for (i = gap; i < vetor.Length; i++)
                {
                    val = vetor[i];
                    j = i;
                    comp++;
                    while (j >= gap && val < vetor[j - gap])
                    {
                        vetor[j] = vetor[j - gap];
                        j = j - gap;
                        troca++;
                    }
                    vetor[j] = val;
                }
            }
            return vetor;
        }
    }
}


