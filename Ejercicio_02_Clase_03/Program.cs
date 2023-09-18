using ClassLibrary_Ejercicio_02_Clase03;

internal class Program
{
    private static void Main(string[] args)
    {
        Estudiante estudiante1 = new Estudiante("Melo", "001", "Ezequiel");
        estudiante1.SetNotaPrimerParcial(9);
        estudiante1.SetNotaSegundoParcial(8);

        Estudiante estudiante2 = new Estudiante("Cortez", "002", "JuanPablo");
        estudiante2.SetNotaPrimerParcial(10);
        estudiante2.SetNotaSegundoParcial(6);

        Estudiante estudiante3 = new Estudiante("Chambi", "003", "Tobias");
        estudiante3.SetNotaPrimerParcial(2);
        estudiante3.SetNotaSegundoParcial(3);

        Console.WriteLine(estudiante1.Mostrar());
        Console.WriteLine(estudiante2.Mostrar());
        Console.WriteLine(estudiante3.Mostrar());
    }
}