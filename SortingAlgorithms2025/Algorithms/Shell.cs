using SortingAlgorithms2025.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms2025.Algorithms
{
    public class Shell : ISort
    {
        public void Sort(int[] array)
        {
            int n = array.Length;

            int gap = n / 2;

            while (gap > 0)
            {
                // Performs a "gapped" insertion sort
                for (int i = gap; i < n; i++)
                {
                    // Current element to be placed correctly
                    int temp = array[i];
                    int j = i;

                    // Like insertion sort, shift elements greater than temp up,
                    // but instead of going down the array by 1, go down by gap
                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }
                    // Place temp in correct location
                    array[j] = temp;
                }
                gap = gap / 2;
            }
        }

        public override string ToString()
        {
            return "Shell sort";
        }
    }
}
