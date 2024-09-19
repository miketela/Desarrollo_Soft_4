using System;

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string NIF { get; set; }

    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, NIF: {NIF}");
    }
}

class Trabajador : Persona
{
    public int Sueldo { get; set; }

    public Trabajador(string nombre, int edad, string nif, int sueldo)
        : base(nombre, edad, nif)
    {
        Sueldo = sueldo;
    }

    public void MostrarInfoTrabajador()
    {
        MostrarInfo();
        Console.WriteLine($"Sueldo: {Sueldo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Trabajador trabajador = new Trabajador("Juan", 30, "12345678A", 3000);
        trabajador.MostrarInfoTrabajador();
    }
}