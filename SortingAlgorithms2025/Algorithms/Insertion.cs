using SortingAlgorithms2025.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms2025.Algorithms
{
    public class Insertion : ISort
    {
        public void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n - 1; i++)
            {
                int currentElement = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > currentElement)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = currentElement;
            }
        }

        public override string ToString()
        {
            return "Insertion Sort";
        }
    }
}
