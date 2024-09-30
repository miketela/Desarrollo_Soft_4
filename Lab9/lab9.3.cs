using System;

namespace Laboratorio93
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = ReadSide("Lado 1: ");
            double side2 = ReadSide("Lado 2: ");
            double side3 = ReadSide("Lado 3: ");

            if (IsValidTriangle(side1, side2, side3))
            {
                Console.WriteLine($"\nEl triángulo es {DetermineTriangleType(side1, side2, side3)}.");
            }
            else
            {
                Console.WriteLine("\nLas longitudes ingresadas no forman un triángulo válido.");
            }
        }

        static double ReadSide(string message)
        {
            double side;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out side) && side > 0)
                {
                    return side;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un valor numérico positivo.");
                }
            }
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            return sides[0] + sides[1] > sides[2];
        }

        static string DetermineTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "equilátero";
            else if (a == b || b == c || a == c)
                return "isósceles";
            else
                return "escaleno";
        }
    }
}