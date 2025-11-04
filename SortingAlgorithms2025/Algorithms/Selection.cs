using SortingAlgorithms2025.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms2025.Algorithms
{
    public class Selection : ISort
    {
        public void Sort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }

                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
        public override string ToString()
        {
            return "Selection Sort";
        }
    }
}
