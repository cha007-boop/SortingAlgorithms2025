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
            for (int i = 1; i < n; i++)
            {
                int currentElement = array[i];
                int j = i - 1;

                // Shift elements of array[0..i-1], that are greater than currentElement,
                // up by one index to make space for currentElement
                while (j >= 0 && array[j] > currentElement)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                // Place currentElement at its correct position
                array[j + 1] = currentElement;
            }
        }

        public override string ToString()
        {
            return "Insertion Sort";
        }
    }
}
