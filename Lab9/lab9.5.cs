using System;

namespace Laboratorio95
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumbers randomNumbers = new RandomNumbers();

            // Generar dos números aleatorios para definir el rango
            int min = randomNumbers.GenerateNumberBetween(1, 50);
            int max = randomNumbers.GenerateNumberBetween(51, 100);

            if (min > max)
            {
                // Intercambiar si min es mayor que max
                int temp = min;
                min = max;
                max = temp;
            }

            Console.WriteLine($"Generando números no repetidos entre {min} y {max}:");

            int count = 10; // Cantidad de números a generar

            try
            {
                int[] uniqueNumbers = randomNumbers.GenerateUniqueNumberArray(count, min, max);
                Console.WriteLine("Números generados:");
                foreach (int number in uniqueNumbers)
                {
                    Console.WriteLine(number);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}