using SortingAlgorithms2025;
using SortingAlgorithms2025.Algorithms;
using SortingAlgorithms2025.Interfaces;
using System.Diagnostics;

int[] ints100 = Read.ReadNumbersFromFile("100.txt");
int[] ints1000 = Read.ReadNumbersFromFile("1000.txt");
int[] ints10000 = Read.ReadNumbersFromFile("10000.txt");
int[] semiSorted = Read.ReadNumbersFromFile("semisorted.txt");
int[] worstCase = Read.ReadNumbersFromFile("worstcase.txt");



List<ISort> algorithms = new List<ISort>
{
    new Bubble(),
    new Insertion(),
    new Selection(),
    new Shell(),
    new Quick()
};


void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
    Console.WriteLine();
}


/*
// Start tidsmåling med Stopwatch
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
// Kald din sorteringsalgoritme her

//algorithms[0].Sort(ints10000);
//algorithms[1].Sort(ints10000);
//algorithms[2].Sort(ints10000);
//algorithms[3].Sort(ints10000);
//algorithms[4].Sort(ints10000);

// Stop tidsmåling
stopwatch.Stop();

PrintArray(ints10000);

// Udskriv tiden, det tog at sortere arrayet
Console.WriteLine($"Tid til at sortere: {stopwatch.Elapsed.TotalMilliseconds} ms");
*/



Console.WriteLine("---------------------------ints10000---------------------------");

Sort.Test(ints10000, algorithms, 10);

Console.WriteLine("---------------------------semisorted---------------------------");

Sort.Test(semiSorted, algorithms, 10);

Console.WriteLine("---------------------------worstcase---------------------------");

Sort.Test(worstCase, algorithms, 10);
