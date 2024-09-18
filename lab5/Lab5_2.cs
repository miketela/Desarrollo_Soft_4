
using System;

class Program {
    static void Main(string[] args) {
        int[,] matriz = new int[3, 4];
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write($"Ingrese el valor para la posición [{i}, {j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("La matriz ingresada es:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write(matriz[i, j] + "	");
            }
            Console.WriteLine();
        }
    }
}
