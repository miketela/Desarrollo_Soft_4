using System;

namespace Laboratorio94
{
    public class RandomNumbers
    {
        private Random random;

        public RandomNumbers()
        {
            random = new Random();
        }

        // Generate a number between two numbers
        public int GenerateNumberBetween(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        // Generate an array of numbers between two numbers
        public int[] GenerateNumberArray(int count, int min, int max)
        {
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RandomNumbers randomNumbers = new RandomNumbers();

            int number = randomNumbers.GenerateNumberBetween(1, 10);
            Console.WriteLine($"Generated number between 1 and 10: {number}");

            int[] array = randomNumbers.GenerateNumberArray(5, 1, 20);
            Console.WriteLine("Array of numbers generated between 1 and 20:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}