using System;

class Program
{
    static void Main()
    {
        // Variables
        double baseNum, resultado;
        int exponenteFinal;

        // Entrada de datos
        Console.WriteLine("Escribe la base de la potencia:");
        baseNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Escribe hasta cual exponente se va calcular:");
        exponenteFinal = int.Parse(Console.ReadLine());

        // Bucle Para en C#
        for (int x = 1; x <= exponenteFinal; x++)
        {
            resultado = Math.Pow(baseNum, x);
            Console.WriteLine($"{baseNum} ^ {x} = {resultado}");
        }

        Console.WriteLine("Proceso terminado.");
    }
}
