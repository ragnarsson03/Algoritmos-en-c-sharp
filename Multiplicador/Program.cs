Console.Write("Ingrese el número hasta donde se va a multiplicar por 7: ");
int x2 = int.Parse(Console.ReadLine());

for (int x = 1; x <= x2; x++)
{
    int resultado = 7 * x;
    Console.WriteLine("7 * " + x + " = " + resultado);
}
