
using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Dictionary<string, string> paises = new Dictionary<string, string> {
            {"Argentina", "Buenos Aires"},
            {"Brasil", "Brasilia"},
            {"Chile", "Santiago"}
        };

        Console.WriteLine("Países y sus capitales:");
        foreach (KeyValuePair<string, string> entry in paises) {
            Console.WriteLine($"País: {entry.Key}, Capital: {entry.Value}");
        }
    }
}
