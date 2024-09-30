using System;

namespace Laboratorio91
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            while (true)
            {
                Console.Write("Ingrese el precio del producto (valor positivo): ");
                if (double.TryParse(Console.ReadLine(), out price) && price > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un valor numérico positivo.");
                }
            }

            string paymentMethod;
            while (true)
            {
                Console.Write("Ingrese la forma de pago (efectivo o tarjeta): ");
                paymentMethod = Console.ReadLine().ToLower();
                if (paymentMethod == "efectivo" || paymentMethod == "tarjeta")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese 'efectivo' o 'tarjeta'.");
                }
            }

            if (paymentMethod == "tarjeta")
            {
                string accountNumber;
                while (true)
                {
                    Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                    accountNumber = Console.ReadLine();
                    if (accountNumber.Length == 16 && long.TryParse(accountNumber, out _))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El número de cuenta debe tener 16 dígitos numéricos.");
                    }
                }

                Console.WriteLine($"\nPago realizado con tarjeta. Precio: {price:C}. Número de cuenta: {accountNumber}");
            }
            else
            {
                Console.WriteLine($"\nPago realizado en efectivo. Precio: {price:C}.");
            }

            Console.WriteLine("Gracias por su compra.");
        }
    }
}