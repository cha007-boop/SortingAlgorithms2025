using SortingAlgorithms2025.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms2025
{
    public static class Sort
    {
        public static void Test(int[] arrayToSort, List<ISort> algorithms, int iterations)
        {
            Stopwatch stopwatch = new Stopwatch();
            foreach (ISort algorithm in algorithms)
            {
                Console.WriteLine(algorithm.ToString());
                for (int i = 0; i < iterations; i++)
                {
                    int[] arrayCopy = arrayToSort.ToArray();
                    stopwatch.Restart();
                    algorithm.Sort(arrayCopy);
                    stopwatch.Stop();
                    Console.WriteLine($"Iteration {i + 1}: {stopwatch.Elapsed.TotalMilliseconds} ms");
                }
                Console.WriteLine();
            }
        }
    }
}
