
using System;

class Program {
    static void Main(string[] args) {
        int[] sueldos = new int[5];
        for (int i = 0; i < sueldos.Length; i++) {
            Console.Write($"Ingrese el sueldo del operario {i + 1}: ");
            sueldos[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Los sueldos ingresados son:");
        foreach (int sueldo in sueldos) {
            Console.WriteLine(sueldo);
        }
    }
}
