
using System;

class Dado {
    private Random random;
    public int Valor { get; private set; }

    public Dado() {
        random = new Random();
        Tirar();
    }

    public void Tirar() {
        Valor = random.Next(1, 7); // Valores entre 1 y 6
    }
}

class JuegoDados {
    private Dado dado1;
    private Dado dado2;
    private Dado dado3;

    public JuegoDados() {
        dado1 = new Dado();
        dado2 = new Dado();
        dado3 = new Dado();
    }

    public void Jugar() {
        dado1.Tirar();
        dado2.Tirar();
        dado3.Tirar();
        Console.WriteLine($"Resultados: {dado1.Valor}, {dado2.Valor}, {dado3.Valor}");

        if (dado1.Valor == dado2.Valor && dado2.Valor == dado3.Valor) {
            Console.WriteLine("Ganó");
        } else {
            Console.WriteLine("Perdió");
        }
    }
}

class Program {
    static void Main(string[] args) {
        JuegoDados juego = new JuegoDados();
        juego.Jugar();
    }
}
