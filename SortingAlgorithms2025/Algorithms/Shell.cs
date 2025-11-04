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
                for (int i = gap; i < n - 1; i++)
                {
                    // Current element to be placed correctly
                    int temp = array[i];
                    int j = i;

                    // Shift all elements greater than temp to make space  
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
