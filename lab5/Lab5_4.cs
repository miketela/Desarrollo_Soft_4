
using System;

class Program {
    static void Main(string[] args) {
        double[] calificaciones = new double[5];
        double suma = 0;

        for (int i = 0; i < calificaciones.Length; i++) {
            Console.Write($"Ingrese la calificación {i + 1}: ");
            calificaciones[i] = double.Parse(Console.ReadLine());
            suma += calificaciones[i];
        }

        double promedio = suma / calificaciones.Length;
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}
