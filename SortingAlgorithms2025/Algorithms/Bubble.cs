using SortingAlgorithms2025.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms2025.Algorithms
{
    public class Bubble : ISort
    {
        public void Sort(int[] array)
        {
            int n = array.Length;
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        //Swap(ref array[i], ref array[i + 1]);
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                n--;
            }
        }

        // Alternatively only using forloops
        public void Sort2(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Second for loop goes to n-i-1 because last i elements are already sorted
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public override string ToString()
        {
            return "Bubble Sort";
        }

        //public void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
    }
}
