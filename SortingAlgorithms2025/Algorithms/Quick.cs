using SortingAlgorithms2025.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms2025.Algorithms
{
    public class Quick : ISort
    {
        public void Sort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        private void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Find the correct location for the pivot-element in the sorted array
                int pivotIndex = Partition(array, low, high);

                // Recursivly apply QuickSort on elements before pivot
                if (pivotIndex > 1)
                    QuickSort(array, low, pivotIndex - 1);

                // Recursively apply QuickSort on elements after pivot
                if (pivotIndex + 1 < high)
                    QuickSort(array, pivotIndex + 1, high);
            }
        }

        /// <summary>
        /// Moves elements smaller than pivot to left and greater to right.
        /// </summary>
        /// <remarks>
        /// All elements with index lower than pivot will be less than or equal to pivot.
        /// All elements with index higher than pivot will be greater than pivot.
        /// So the pivot-element is in its correct sorted position.
        /// </remarks>
        /// <returns>
        /// Returns the correct index of the pivot element.
        /// </returns>
        private int Partition2(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }

            Swap(ref array[i + 1], ref array[high]);
            return i + 1;
        }

        // More effecient than Partition2
        private int Partition(int[] array, int l, int r)
        {
            int midt = (l + r) / 2;
            int pivot = array[midt];

            while (l <= r)
            {
                while (array[l] < pivot)
                {
                    l++;
                }

                while (array[r] > pivot)
                {
                    r--;
                }

                if (l <= r)
                {
                    Swap(ref array[l], ref array[r]);
                    l++;
                    r--;
                }
            }
            return l;
        }

        /// <summary>
        /// Swap two integers by reference.
        /// </summary>
        /// <param name="a"> First integer to swap</param>
        /// <param name="b"> Second integer to swap</param>
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public override string ToString()
        {
            return "Quick Sort";
        }
    }
}
