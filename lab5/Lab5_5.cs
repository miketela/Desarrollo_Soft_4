
using System;
using System.Collections.Generic;

class Estudiante {
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad) {
        Nombre = nombre;
        Edad = edad;
    }
}

class Program {
    static void Main(string[] args) {
        List<Estudiante> estudiantes = new List<Estudiante> {
            new Estudiante("Juan", 20),
            new Estudiante("María", 22),
            new Estudiante("Pedro", 19)
        };

        Console.WriteLine("Estudiantes registrados:");
        foreach (Estudiante estudiante in estudiantes) {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}");
        }
    }
}
