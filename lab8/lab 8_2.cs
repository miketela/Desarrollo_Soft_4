using System;

class Cuenta
{
    public string Numero { get; set; }
    public double Saldo { get; set; }

    public Cuenta(string numero, double saldo)
    {
        Numero = numero;
        Saldo = saldo;
    }

    public virtual double CalcularIntereses()
    {
        return Saldo * 0.02; // 2% de interés base
    }
}

class CuentaAhorro : Cuenta
{
    public CuentaAhorro(string numero, double saldo)
        : base(numero, saldo)
    {
    }

    public override double CalcularIntereses()
    {
        return Saldo * 0.04; // 4% de interés para cuentas de ahorro
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cuenta cuentaBase = new Cuenta("12345", 1000);
        CuentaAhorro cuentaAhorro = new CuentaAhorro("67890", 1000);

        Console.WriteLine($"Interés de la cuenta base: {cuentaBase.CalcularIntereses()}");
        Console.WriteLine($"Interés de la cuenta de ahorro: {cuentaAhorro.CalcularIntereses()}");
    }
}