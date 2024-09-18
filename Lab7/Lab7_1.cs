
using System;

class Cliente {
    public string Nombre { get; set; }
    public double DineroDepositado { get; private set; }

    public Cliente(string nombre) {
        Nombre = nombre;
        DineroDepositado = 0;
    }

    public void Depositar(double monto) {
        DineroDepositado += monto;
    }

    public void Extraer(double monto) {
        if (DineroDepositado >= monto) {
            DineroDepositado -= monto;
        } else {
            Console.WriteLine($"{Nombre} no tiene suficiente dinero para extraer {monto}");
        }
    }
}

class Banco {
    private Cliente[] clientes;

    public Banco() {
        clientes = new Cliente[3];
        clientes[0] = new Cliente("Cliente 1");
        clientes[1] = new Cliente("Cliente 2");
        clientes[2] = new Cliente("Cliente 3");
    }

    public void Operar() {
        clientes[0].Depositar(1000);
        clientes[1].Depositar(500);
        clientes[2].Depositar(200);

        clientes[0].Extraer(300);
        clientes[1].Extraer(50);
        clientes[2].Extraer(500); // Fallará ya que no tiene suficiente dinero
    }

    public void DepositosTotales() {
        double total = 0;
        foreach (Cliente c in clientes) {
            total += c.DineroDepositado;
        }
        Console.WriteLine($"El total de dinero depositado en el banco es: {total}");
    }
}

class Program {
    static void Main(string[] args) {
        Banco banco = new Banco();
        banco.Operar();
        banco.DepositosTotales();
    }
}
