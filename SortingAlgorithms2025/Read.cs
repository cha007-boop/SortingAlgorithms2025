using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms2025
{
    public static class Read
    {
        public static int[] ReadNumbersFromFile(string filePath)
        {
            try
            { // Læs hele filens indhold som en enkelt streng
                string fileContent = File.ReadAllText(filePath);
                // Split strengen ved kommaer for at få alle tal
                string[] stringNumbers = fileContent.Split(',');
                // Opret et int-array af samme længde som antallet af tal
                int[] numbers = new int[stringNumbers.Length];
                // Konverter hvert tal fra string til int og gem det i arrayet
                for (int i = 0; i < stringNumbers.Length; i++)
                {
                    numbers[i] = int.Parse(stringNumbers[i].Trim());
                }
                return numbers;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl under læsning af fil: " + ex.Message);
                return new int[0]; // Returner et tomt array i tilfælde af fejl } }
            }
        }
    }
}
