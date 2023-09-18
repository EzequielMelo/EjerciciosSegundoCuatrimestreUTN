using ClassLibrary_Ejercicio_01_Clase_03;

internal class Program
{
    private static void Main(string[] args)
    {
        Cuenta nuevaCuenta = new Cuenta("Ezequiel", 25560);

        Console.WriteLine(nuevaCuenta.cuentaToString());

        nuevaCuenta.ingresarDinero(-1);

        Console.WriteLine(nuevaCuenta.cuentaToString());

        nuevaCuenta.ingresarDinero(5420);

        Console.WriteLine(nuevaCuenta.cuentaToString());

        nuevaCuenta.retirarDinero(3200);

        Console.WriteLine(nuevaCuenta.cuentaToString());
    }
}