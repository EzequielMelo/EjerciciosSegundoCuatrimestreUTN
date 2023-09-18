using ClassLibrary_Ejercicio_01_Clase_04_Sumador;

internal class Program
{
    private static void Main(string[] args)
    {
        Sumador sumador1 = new Sumador(4);
        sumador1.Sumar("hola", "pepe");
        sumador1.Sumar(10, 4);
        sumador1.Sumar(3, 1);
        int elSumador;
        elSumador = (int)sumador1;
        Console.WriteLine(elSumador);
        Sumador sumador2 = new Sumador(4);
        sumador2.Sumar("hola", "pepe");
        sumador2.Sumar(10, 4);
        elSumador = (int)sumador2;
        Console.WriteLine(elSumador);
        Console.WriteLine(sumador1 + sumador2);
        Console.WriteLine($"Son iguales: {sumador1 | sumador2}");
    }
}