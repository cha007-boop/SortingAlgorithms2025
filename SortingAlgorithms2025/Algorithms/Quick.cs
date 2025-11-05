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

        /// <summary>
        /// Sorts the array using the QuickSort algorithm.
        /// </summary>
        private void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Find the correct location for the pivot-element in the sorted array
                int pivotIndex = Partition(array, low, high);

                // Recursivly apply QuickSort on elements before pivot
                QuickSort(array, low, pivotIndex - 1);

                // Recursively apply QuickSort on elements after pivot
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        
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

        /// <summary>
        /// Finds the correct index of the pivot element and partitions the array around the pivot.
        /// </summary>
        /// <remarks>
        /// All elements with index lower than pivot will be less than or equal to pivot.
        /// All elements with index higher than pivot will be greater than pivot.
        /// So the pivot-element is in its correct sorted position.
        /// </remarks>
        /// <param name="array"> The array to partition</param>
        /// <param name="left"> The loweset index of the subarray to partition</param>
        /// <param name="right"> The highest index of the subarray to partition</param>
        /// <returns>
        /// Returns the correct index of the pivot element.
        /// </returns>
        private int Partition(int[] array, int left, int right)
        {
            int mid = (left + right) / 2;
            int pivot = array[mid];

            while (left <= right)
            {
                // Increases left index while element at left is less than pivot
                while (array[left] < pivot)
                {
                    left++;
                }

                // Decreases right index while element at right is greater than pivot
                while (array[right] > pivot)
                {
                    right--;
                }

                // If left index is less than or equal to right, swap elements and move indices
                if (left <= right)
                {
                    Swap(ref array[left], ref array[right]);
                    left++;
                    right--;
                }
            }
            // At this point, left is the index of the pivot element in the sorted array
            return left;
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
