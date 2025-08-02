using System;

class Program
{
    // Función que calcula el porcentaje de descuento
    static double ObtenerDescuento(double descuento)
    {
        return descuento / 100.0;
    }

    static void Main()
    {
        // Variables
        double x, resultado, precio, rebaja, total;

        // Entrada de datos
        Console.WriteLine("¿Cuál es el precio de lo que queremos comprar?");
        precio = double.Parse(Console.ReadLine());

        Console.WriteLine("Tiene un descuento");
        Console.WriteLine("¿De cuánto es el descuento?");
        rebaja = double.Parse(Console.ReadLine());

        // Llamada a la función
        x = ObtenerDescuento(rebaja);
        resultado = precio * x;
        total = precio - resultado;

        // Salida
        Console.WriteLine($"El precio con descuento es de: {total}");
    }
}
